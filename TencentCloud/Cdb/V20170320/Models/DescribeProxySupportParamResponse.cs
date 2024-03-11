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

    public class DescribeProxySupportParamResponse : AbstractModel
    {
        
        /// <summary>
        /// 支持最大代理版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }

        /// <summary>
        /// 是否支持连接池
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportPool")]
        public bool? SupportPool{ get; set; }

        /// <summary>
        /// 连接池最小值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoolMin")]
        public ulong? PoolMin{ get; set; }

        /// <summary>
        /// 连接池最大值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoolMax")]
        public ulong? PoolMax{ get; set; }

        /// <summary>
        /// 是否支持事务拆分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportTransSplit")]
        public bool? SupportTransSplit{ get; set; }

        /// <summary>
        /// 支持连接池的最小代理版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportPoolMinVersion")]
        public string SupportPoolMinVersion{ get; set; }

        /// <summary>
        /// 支持事务拆分的最小代理版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportTransSplitMinVersion")]
        public string SupportTransSplitMinVersion{ get; set; }

        /// <summary>
        /// 是否支持设置只读
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportReadOnly")]
        public bool? SupportReadOnly{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
            this.SetParamSimple(map, prefix + "SupportPool", this.SupportPool);
            this.SetParamSimple(map, prefix + "PoolMin", this.PoolMin);
            this.SetParamSimple(map, prefix + "PoolMax", this.PoolMax);
            this.SetParamSimple(map, prefix + "SupportTransSplit", this.SupportTransSplit);
            this.SetParamSimple(map, prefix + "SupportPoolMinVersion", this.SupportPoolMinVersion);
            this.SetParamSimple(map, prefix + "SupportTransSplitMinVersion", this.SupportTransSplitMinVersion);
            this.SetParamSimple(map, prefix + "SupportReadOnly", this.SupportReadOnly);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

