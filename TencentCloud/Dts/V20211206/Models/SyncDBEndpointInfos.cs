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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncDBEndpointInfos : AbstractModel
    {
        
        /// <summary>
        /// 数据库所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例网络接入类型，如：extranet(外网)、ipv6(公网ipv6)、cvm(云主机自建)、dcg(专线接入)、vpncloud(vpn接入的实例)、cdb(云数据库)、ccn(云联网)、intranet(自研上云)、vpc(私有网络)等，注意具体可选值依赖当前链路
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// 实例数据库类型，如：mysql,redis,mongodb,postgresql,mariadb,percona 等
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string DatabaseType{ get; set; }

        /// <summary>
        /// 数据库信息。注意：如果数据库类型为tdsqlmysql，此处Endpoint数组的顺序应满足规则：proxy节点放在set节点之前。如果SrcConnectType选择proxy接入则只需要填写proxy节点即可。如果选择set接入，数组中第一个set节点必须是shardkey范围起始为0的分片
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Info")]
        public Endpoint[] Info{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "DatabaseType", this.DatabaseType);
            this.SetParamArrayObj(map, prefix + "Info.", this.Info);
        }
    }
}

