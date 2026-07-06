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

    public class DescribeLogStorageStatisticResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>返回状态码 0 成功 非0不成功</p>
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }

        /// <summary>
        /// <p>返回信息  success 成功 其他 不成功</p>
        /// </summary>
        [JsonProperty("ReturnMsg")]
        public string ReturnMsg{ get; set; }

        /// <summary>
        /// <p>已使用存储量，单位B</p>
        /// </summary>
        [JsonProperty("UsedSize")]
        public long? UsedSize{ get; set; }

        /// <summary>
        /// <p>配额存储总量，单位B</p>
        /// </summary>
        [JsonProperty("TotalSize")]
        public long? TotalSize{ get; set; }

        /// <summary>
        /// <p>存储天数</p>
        /// </summary>
        [JsonProperty("StorageDay")]
        public long? StorageDay{ get; set; }

        /// <summary>
        /// <p>访问控制日志存储量，单位B</p>
        /// </summary>
        [JsonProperty("AclSize")]
        public long? AclSize{ get; set; }

        /// <summary>
        /// <p>入侵防御日志存储量，单位B</p>
        /// </summary>
        [JsonProperty("IdsSize")]
        public long? IdsSize{ get; set; }

        /// <summary>
        /// <p>流量日志存储量，单位B</p>
        /// </summary>
        [JsonProperty("NetFlowSize")]
        public long? NetFlowSize{ get; set; }

        /// <summary>
        /// <p>操作日志存储量，单位B</p>
        /// </summary>
        [JsonProperty("OperateSize")]
        public long? OperateSize{ get; set; }

        /// <summary>
        /// <p>剩余存储量，单位B</p>
        /// </summary>
        [JsonProperty("LeftSize")]
        public long? LeftSize{ get; set; }

        /// <summary>
        /// <p>计费模式，0后付费，1预付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>每日增加日志存储量柱状图</p>
        /// </summary>
        [JsonProperty("TimeHistogram")]
        public StorageHistogram[] TimeHistogram{ get; set; }

        /// <summary>
        /// <p>柱形图格式数据</p>
        /// </summary>
        [JsonProperty("TimeHistogramShow")]
        public StorageHistogramShow TimeHistogramShow{ get; set; }

        /// <summary>
        /// <p>后付费模式存储状态，0正常，1欠费停止写入</p>
        /// </summary>
        [JsonProperty("ArrearsStopWriting")]
        public long? ArrearsStopWriting{ get; set; }

        /// <summary>
        /// <p>NDR流量日志存储量，单位B</p>
        /// </summary>
        [JsonProperty("NDRNetFlowSize")]
        public long? NDRNetFlowSize{ get; set; }

        /// <summary>
        /// <p>NDR风险日志存储量，单位B</p>
        /// </summary>
        [JsonProperty("NDRRiskSize")]
        public long? NDRRiskSize{ get; set; }

        /// <summary>
        /// <p>NDR日志存储天数</p>
        /// </summary>
        [JsonProperty("NDRStorageDay")]
        public long? NDRStorageDay{ get; set; }

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
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMsg", this.ReturnMsg);
            this.SetParamSimple(map, prefix + "UsedSize", this.UsedSize);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "StorageDay", this.StorageDay);
            this.SetParamSimple(map, prefix + "AclSize", this.AclSize);
            this.SetParamSimple(map, prefix + "IdsSize", this.IdsSize);
            this.SetParamSimple(map, prefix + "NetFlowSize", this.NetFlowSize);
            this.SetParamSimple(map, prefix + "OperateSize", this.OperateSize);
            this.SetParamSimple(map, prefix + "LeftSize", this.LeftSize);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamArrayObj(map, prefix + "TimeHistogram.", this.TimeHistogram);
            this.SetParamObj(map, prefix + "TimeHistogramShow.", this.TimeHistogramShow);
            this.SetParamSimple(map, prefix + "ArrearsStopWriting", this.ArrearsStopWriting);
            this.SetParamSimple(map, prefix + "NDRNetFlowSize", this.NDRNetFlowSize);
            this.SetParamSimple(map, prefix + "NDRRiskSize", this.NDRRiskSize);
            this.SetParamSimple(map, prefix + "NDRStorageDay", this.NDRStorageDay);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

