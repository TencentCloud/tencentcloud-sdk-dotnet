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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络组id(cynosdbmysql-grp-前缀开头)或集群id（例如 cynosdbmysql-xxxxxxxx前缀）,当通过实例IP地址三元组（UniqVpcId、Vip、Vport）配置安全组时，该字段必须设置为集群ID（例如 cynosdbmysql-xxxxxxxx前缀）。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 要修改的安全组ID列表，一个或者多个安全组ID组成的数组。
        /// 注意：该入参会全量替换存量已有集合，非增量更新。修改需传入预期的全量集合。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例所属VPC网络ID,（UniqVpcId、Vip 和 Vport 三个参数需同时指定，用于唯一标识网络实例）
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 实例IP地址,实例IP地址三元组UniqVpcId、Vip 和 Vport) 三个参数需同时指定，用于唯一标识网络实实例
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 实例端口,实例IP地址三元组UniqVpcId、Vip 和 Vport) 三个参数需同时指定，用于唯一标识网络实实例
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
        }
    }
}

