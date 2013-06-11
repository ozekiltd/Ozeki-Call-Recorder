using System;
using System.Collections.Generic;

namespace CallRecorder.Util
{
	/// <summary>
	/// A rendszerben található függőségeket létrehozó factory-ket tároljuk benne (Func<T>-t értek factory alatt).
	/// </summary>
	public class SimpleIOCContainer
	{
		static readonly SimpleIOCContainer instance = new SimpleIOCContainer();

		readonly Dictionary<Type, Tuple<Func<object>, bool>> dependencyCache;
		readonly Dictionary<Type, Object> objectCache;
		readonly object sync;

		SimpleIOCContainer()
		{
			dependencyCache = new Dictionary<Type, Tuple<Func<object>, bool>>();
			objectCache = new Dictionary<Type, object>();
			sync = new object();
		}

		public static SimpleIOCContainer Instance
		{
			get { return instance; }
		}

		/// <summary>
		/// Ki akarnak kérdezni egy adott típusú függőséget.
		/// Ha a függőség nincs benne a rendszerben, akkor excpetion -t dob (és ez jól van így, nem szabad elfedni a hibákat).
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public T Resolve<T>() where T : class
		{
			return (T)Resolve(typeof(T));
		}

		/// <summary>
		/// Hozzáadunk egy újabb függőséget.
		/// Az isSingleton értéke határozza meg, hogy mindig létrehozzunk egy adott nevű függőséget vagy csak egyszer
		/// Megj: A .NET 3.5 nem támogatja a covariancia-t/contravarianciat ezert kenytelen voltam Func<object> et írni
		/// Func<T> helyett, ezért figyelj oda, amikor a delegate et írod, mert bármit elfogad visszatérési értéknek, ami object
		/// </summary>
		public void AddDependency<T>(Func<T> func, bool isSingleton = true) where T : class
		{
			lock (sync)
			{
				if (dependencyCache.ContainsKey(typeof(T)))
					throw new Exception(typeof(T) + "Dependency already configured");

				dependencyCache.Add(typeof(T), new Tuple<Func<object>, bool>(func, isSingleton));
			}
		}


		object Resolve(Type type)
		{
			lock (sync)
			{
				if (!dependencyCache.ContainsKey(type))
					throw new Exception("Dependency container does not contain this type: " + type);

				var tuple = dependencyCache[type];

				if (tuple.Item2) // Singleton (mindig ugyanazt a példányt adja vissza)
				{
					if (objectCache.ContainsKey(type))
						return objectCache[type];

					var dependency = tuple.Item1();
					objectCache[type] = dependency;

					return dependency;
				}

				return tuple.Item1();
			}
		}
	}
}
