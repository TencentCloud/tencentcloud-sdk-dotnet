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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewLogStorageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>日志已使用存储容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("UsedBytes")]
        public long? UsedBytes{ get; set; }

        /// <summary>
        /// <p>日志总存储容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("TotalBytes")]
        public long? TotalBytes{ get; set; }

        /// <summary>
        /// <p>日志保留天数。</p><p>单位：天</p>
        /// </summary>
        [JsonProperty("StorageDay")]
        public long? StorageDay{ get; set; }

        /// <summary>
        /// <p>NDR 日志保留天数。</p><p>单位：天</p>
        /// </summary>
        [JsonProperty("NDRStorageDay")]
        public long? NDRStorageDay{ get; set; }

        /// <summary>
        /// <p>访问控制日志占用容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("AclSize")]
        public long? AclSize{ get; set; }

        /// <summary>
        /// <p>入侵检测日志占用容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("IdsSize")]
        public long? IdsSize{ get; set; }

        /// <summary>
        /// <p>流量日志占用容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("NetFlowSize")]
        public long? NetFlowSize{ get; set; }

        /// <summary>
        /// <p>操作日志占用容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("OperateSize")]
        public long? OperateSize{ get; set; }

        /// <summary>
        /// <p>NDR 风险日志占用容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("NDRRiskSize")]
        public long? NDRRiskSize{ get; set; }

        /// <summary>
        /// <p>NDR 流量日志占用容量，单位为 Byte。</p><p>单位：Byte</p>
        /// </summary>
        [JsonProperty("NDRNetFlowSize")]
        public long? NDRNetFlowSize{ get; set; }

        /// <summary>
        /// <p>日志存储计费模式标识。</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>是否因欠费停止写入日志的状态标识。</p>
        /// </summary>
        [JsonProperty("ArrearsStopWriting")]
        public long? ArrearsStopWriting{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsedBytes", this.UsedBytes);
            this.SetParamSimple(map, prefix + "TotalBytes", this.TotalBytes);
            this.SetParamSimple(map, prefix + "StorageDay", this.StorageDay);
            this.SetParamSimple(map, prefix + "NDRStorageDay", this.NDRStorageDay);
            this.SetParamSimple(map, prefix + "AclSize", this.AclSize);
            this.SetParamSimple(map, prefix + "IdsSize", this.IdsSize);
            this.SetParamSimple(map, prefix + "NetFlowSize", this.NetFlowSize);
            this.SetParamSimple(map, prefix + "OperateSize", this.OperateSize);
            this.SetParamSimple(map, prefix + "NDRRiskSize", this.NDRRiskSize);
            this.SetParamSimple(map, prefix + "NDRNetFlowSize", this.NDRNetFlowSize);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ArrearsStopWriting", this.ArrearsStopWriting);
        }
    }
}

