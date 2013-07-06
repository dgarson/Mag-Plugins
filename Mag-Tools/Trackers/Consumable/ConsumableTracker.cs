﻿using System;

namespace MagTools.Trackers.Consumable
{
	class ConsumableTracker : IDisposable
	{
		//public event Action<TrackedCorpse> ItemAdded;
		//public event Action<TrackedCorpse> ItemChanged;
		//public event Action<TrackedCorpse> ItemRemoved;

		public ConsumableTracker()
		{
			try
			{
			}
			catch (Exception ex) { Debug.LogException(ex); }
		}

		private bool disposed;

		public void Dispose()
		{
			Dispose(true);

			// Use SupressFinalize in case a subclass
			// of this type implements a finalizer.
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			// If you need thread safety, use a lock around these 
			// operations, as well as in your methods that use the resource.
			if (!disposed)
			{
				if (disposing)
				{
				}

				// Indicate that the instance has been disposed.
				disposed = true;
			}
		}
	}
}
