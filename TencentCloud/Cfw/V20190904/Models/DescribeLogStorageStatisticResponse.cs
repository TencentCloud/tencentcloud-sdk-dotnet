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
        /// 返回状态码 0 成功 非0不成功
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }

        /// <summary>
        /// 返回信息  success 成功 其他 不成功
        /// </summary>
        [JsonProperty("ReturnMsg")]
        public string ReturnMsg{ get; set; }

        /// <summary>
        /// 已使用存储量，单位B
        /// </summary>
        [JsonProperty("UsedSize")]
        public long? UsedSize{ get; set; }

        /// <summary>
        /// 配额存储总量，单位B
        /// </summary>
        [JsonProperty("TotalSize")]
        public long? TotalSize{ get; set; }

        /// <summary>
        /// 存储天数
        /// </summary>
        [JsonProperty("StorageDay")]
        public long? StorageDay{ get; set; }

        /// <summary>
        /// 访问控制日志存储量，单位B
        /// </summary>
        [JsonProperty("AclSize")]
        public long? AclSize{ get; set; }

        /// <summary>
        /// 入侵防御日志存储量，单位B
        /// </summary>
        [JsonProperty("IdsSize")]
        public long? IdsSize{ get; set; }

        /// <summary>
        /// 流量日志存储量，单位B
        /// </summary>
        [JsonProperty("NetFlowSize")]
        public long? NetFlowSize{ get; set; }

        /// <summary>
        /// 操作日志存储量，单位B
        /// </summary>
        [JsonProperty("OperateSize")]
        public long? OperateSize{ get; set; }

        /// <summary>
        /// 剩余存储量，单位B
        /// </summary>
        [JsonProperty("LeftSize")]
        public long? LeftSize{ get; set; }

        /// <summary>
        /// 计费模式，0后付费，1预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 每日增加日志存储量柱状图
        /// </summary>
        [JsonProperty("TimeHistogram")]
        public StorageHistogram[] TimeHistogram{ get; set; }

        /// <summary>
        /// 柱形图格式数据
        /// </summary>
        [JsonProperty("TimeHistogramShow")]
        public StorageHistogramShow TimeHistogramShow{ get; set; }

        /// <summary>
        /// 后付费模式存储状态，0正常，1欠费停止写入
        /// </summary>
        [JsonProperty("ArrearsStopWriting")]
        public long? ArrearsStopWriting{ get; set; }

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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

