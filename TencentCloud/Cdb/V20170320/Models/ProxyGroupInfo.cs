/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 代理组ID
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// 代理版本
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }

        /// <summary>
        /// 代理支持升级版本
        /// </summary>
        [JsonProperty("SupportUpgradeProxyVersion")]
        public string SupportUpgradeProxyVersion{ get; set; }

        /// <summary>
        /// 代理状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 代理任务状态
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 代理组节点信息
        /// </summary>
        [JsonProperty("ProxyNode")]
        public ProxyNode[] ProxyNode{ get; set; }

        /// <summary>
        /// 代理组地址信息
        /// </summary>
        [JsonProperty("ProxyAddress")]
        public ProxyAddress[] ProxyAddress{ get; set; }

        /// <summary>
        /// 连接池阈值
        /// </summary>
        [JsonProperty("ConnectionPoolLimit")]
        public ulong? ConnectionPoolLimit{ get; set; }

        /// <summary>
        /// 支持创建地址
        /// </summary>
        [JsonProperty("SupportCreateProxyAddress")]
        public bool? SupportCreateProxyAddress{ get; set; }

        /// <summary>
        /// 支持升级代理版本所需的cdb版本
        /// </summary>
        [JsonProperty("SupportUpgradeProxyMysqlVersion")]
        public string SupportUpgradeProxyMysqlVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
            this.SetParamSimple(map, prefix + "SupportUpgradeProxyVersion", this.SupportUpgradeProxyVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamArrayObj(map, prefix + "ProxyNode.", this.ProxyNode);
            this.SetParamArrayObj(map, prefix + "ProxyAddress.", this.ProxyAddress);
            this.SetParamSimple(map, prefix + "ConnectionPoolLimit", this.ConnectionPoolLimit);
            this.SetParamSimple(map, prefix + "SupportCreateProxyAddress", this.SupportCreateProxyAddress);
            this.SetParamSimple(map, prefix + "SupportUpgradeProxyMysqlVersion", this.SupportUpgradeProxyMysqlVersion);
        }
    }
}

