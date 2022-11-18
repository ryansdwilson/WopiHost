﻿namespace WopiHost.Core.Models;

	/// <summary>
	/// Implemented in accordance with: https://wopirest.readthedocs.io/en/latest/bootstrapper/GetRootContainer.html#sample-response
	/// </summary>
	public class BootstrapRootContainerInfo
	{
		/// <summary>
		/// Object describing the root container.
		/// </summary>
		public RootContainerInfo RootContainerInfo { get; set; }

		/// <summary>
		/// Object with properties necessary for calling the /bootstrap operation.
		/// </summary>
		public BootstrapInfo Bootstrap { get; set; }

		/// <summary>
		/// A WOPI access token.
		/// </summary>
		public AccessTokenInfo AccessTokenInfo { get; set; }
	}