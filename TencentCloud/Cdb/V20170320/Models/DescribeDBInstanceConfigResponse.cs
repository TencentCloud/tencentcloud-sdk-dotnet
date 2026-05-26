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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>主实例数据保护方式，可能的返回值：0 - 异步复制方式，1 - 半同步复制方式，2 - 强同步复制方式。</p>
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// <p>主实例部署方式，可能的返回值：0 - 单可用部署，1 - 多可用区部署。</p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// <p>实例主可用区信息，格式如 &quot;ap-shanghai-2&quot;。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>双节点、三节点、四节点实例第一备库的配置信息。</p><p>查询双节点时，此参数返回为双节点的备库信息；查询三节点、四节点时，此参数返回为实例的第一备库信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlaveConfig")]
        public SlaveConfig SlaveConfig{ get; set; }

        /// <summary>
        /// <p>三节点、四节点实例第二备库的配置信息。</p><p>查询三节点、四节点时，此参数返回为第二备库的信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupConfig")]
        public BackupConfig BackupConfig{ get; set; }

        /// <summary>
        /// <p>是否切换备库。</p>
        /// </summary>
        [JsonProperty("Switched")]
        public bool? Switched{ get; set; }

        /// <summary>
        /// <p>四节点实例第三备库的配置信息。</p><p>查询四节点时，此参数返回为第三备库的信息。</p>
        /// </summary>
        [JsonProperty("FourthConfig")]
        public BackupConfig FourthConfig{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamObj(map, prefix + "SlaveConfig.", this.SlaveConfig);
            this.SetParamObj(map, prefix + "BackupConfig.", this.BackupConfig);
            this.SetParamSimple(map, prefix + "Switched", this.Switched);
            this.SetParamObj(map, prefix + "FourthConfig.", this.FourthConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

