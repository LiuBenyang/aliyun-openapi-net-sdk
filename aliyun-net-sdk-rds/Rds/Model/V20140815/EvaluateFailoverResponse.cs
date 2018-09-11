/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class EvaluateFailoverResponse : AcsResponse
	{

		private string requestId;

		private string replicaId;

		private string evaluateResult;

		private List<EvaluateFailover_ItemsItem> items;

		private List<EvaluateFailover_ReportsItem> reports;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string ReplicaId
		{
			get
			{
				return replicaId;
			}
			set	
			{
				replicaId = value;
			}
		}

		public string EvaluateResult
		{
			get
			{
				return evaluateResult;
			}
			set	
			{
				evaluateResult = value;
			}
		}

		public List<EvaluateFailover_ItemsItem> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public List<EvaluateFailover_ReportsItem> Reports
		{
			get
			{
				return reports;
			}
			set	
			{
				reports = value;
			}
		}

		public class EvaluateFailover_ItemsItem
		{

			private string dBInstanceId;

			private string regionId;

			private string role;

			private string readWriteType;

			private string instanceNetworkType;

			private string securityIPList;

			private bool? hasInternetIP;

			private string internetIP;

			private List<EvaluateFailover_AccountsItem> accounts;

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
				}
			}

			public string ReadWriteType
			{
				get
				{
					return readWriteType;
				}
				set	
				{
					readWriteType = value;
				}
			}

			public string InstanceNetworkType
			{
				get
				{
					return instanceNetworkType;
				}
				set	
				{
					instanceNetworkType = value;
				}
			}

			public string SecurityIPList
			{
				get
				{
					return securityIPList;
				}
				set	
				{
					securityIPList = value;
				}
			}

			public bool? HasInternetIP
			{
				get
				{
					return hasInternetIP;
				}
				set	
				{
					hasInternetIP = value;
				}
			}

			public string InternetIP
			{
				get
				{
					return internetIP;
				}
				set	
				{
					internetIP = value;
				}
			}

			public List<EvaluateFailover_AccountsItem> Accounts
			{
				get
				{
					return accounts;
				}
				set	
				{
					accounts = value;
				}
			}

			public class EvaluateFailover_AccountsItem
			{

				private string accountPrivilege;

				private string accountStatus;

				private string accountPrivilegeDetail;

				private string accountDescription;

				private string accountID;

				private string accountName;

				private string privExceeded;

				private string engine;

				private string accountType;

				public string AccountPrivilege
				{
					get
					{
						return accountPrivilege;
					}
					set	
					{
						accountPrivilege = value;
					}
				}

				public string AccountStatus
				{
					get
					{
						return accountStatus;
					}
					set	
					{
						accountStatus = value;
					}
				}

				public string AccountPrivilegeDetail
				{
					get
					{
						return accountPrivilegeDetail;
					}
					set	
					{
						accountPrivilegeDetail = value;
					}
				}

				public string AccountDescription
				{
					get
					{
						return accountDescription;
					}
					set	
					{
						accountDescription = value;
					}
				}

				public string AccountID
				{
					get
					{
						return accountID;
					}
					set	
					{
						accountID = value;
					}
				}

				public string AccountName
				{
					get
					{
						return accountName;
					}
					set	
					{
						accountName = value;
					}
				}

				public string PrivExceeded
				{
					get
					{
						return privExceeded;
					}
					set	
					{
						privExceeded = value;
					}
				}

				public string Engine
				{
					get
					{
						return engine;
					}
					set	
					{
						engine = value;
					}
				}

				public string AccountType
				{
					get
					{
						return accountType;
					}
					set	
					{
						accountType = value;
					}
				}
			}
		}

		public class EvaluateFailover_ReportsItem
		{

			private string checkType;

			private string severity;

			private string reasonCode;

			private string reasonMessage;

			public string CheckType
			{
				get
				{
					return checkType;
				}
				set	
				{
					checkType = value;
				}
			}

			public string Severity
			{
				get
				{
					return severity;
				}
				set	
				{
					severity = value;
				}
			}

			public string ReasonCode
			{
				get
				{
					return reasonCode;
				}
				set	
				{
					reasonCode = value;
				}
			}

			public string ReasonMessage
			{
				get
				{
					return reasonMessage;
				}
				set	
				{
					reasonMessage = value;
				}
			}
		}
	}
}