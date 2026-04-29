/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCkSqlApisRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>api接口名称,GetClusters:获取集群cluster列表<br>GetSystemUsers:获取系统用户列表<br>CheckNodeCluster: 检查节点是否隶属一个cluster<br>GetClusterDatabases: 获取一个cluster下的数据库列表<br>GetClusterTables: 获取一个cluster下的数据库表列表<br>GetPrivilegeUsers: 获取授权的用户列表<br>GET_USER_CLUSTER_PRIVILEGES:获取用户cluster下的权限<br>GetUserClusterNewPrivileges:获取用户cluster下的权限 (新版）<br>RevokeClusterUser:解绑cluster用户<br>DeleteSystemUser:删除系统用户 —— 必须所有cluster先解绑<br>GetUserOptionMessages:获取用户配置备注信息<br>GET_USER_CONFIGS:获取用户配置列表  QUOTA、PROFILE、POLICY</p>
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }

        /// <summary>
        /// <p>clickhouse逻辑集群名称，可通过连接集群执行 <code>SHOW CLUSTERS</code> 查询获得。当 ApiType 取值为 GET_SYSTEM_USERS、GET_PRIVILEGE_USERS、GET_CLUSTER_DATABASES或GET_CLUSTER_TABLES 时，本参数必填。</p>
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// <p>用户名称，api与user相关的必填</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>账户的类型</p>
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
        }
    }
}

