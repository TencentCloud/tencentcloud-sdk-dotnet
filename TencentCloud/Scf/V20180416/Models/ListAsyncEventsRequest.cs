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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAsyncEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 过滤条件，函数版本
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// 过滤条件，调用类型列表
        /// </summary>
        [JsonProperty("InvokeType")]
        public string[] InvokeType{ get; set; }

        /// <summary>
        /// 过滤条件，事件状态列表
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 过滤条件，开始执行时间左闭右开区间
        /// </summary>
        [JsonProperty("StartTimeInterval")]
        public TimeInterval StartTimeInterval{ get; set; }

        /// <summary>
        /// 过滤条件，结束执行时间左闭右开区间
        /// </summary>
        [JsonProperty("EndTimeInterval")]
        public TimeInterval EndTimeInterval{ get; set; }

        /// <summary>
        /// 可选值 ASC 和 DESC，默认 DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 可选值 StartTime 和 EndTime，默认值 StartTime
        /// </summary>
        [JsonProperty("Orderby")]
        public string Orderby{ get; set; }

        /// <summary>
        /// 数据偏移量，默认值为 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数据长度，默认值为 20，最大值 100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 过滤条件，事件调用请求id
        /// </summary>
        [JsonProperty("InvokeRequestId")]
        public string InvokeRequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamArraySimple(map, prefix + "InvokeType.", this.InvokeType);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamObj(map, prefix + "StartTimeInterval.", this.StartTimeInterval);
            this.SetParamObj(map, prefix + "EndTimeInterval.", this.EndTimeInterval);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Orderby", this.Orderby);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "InvokeRequestId", this.InvokeRequestId);
        }
    }
}

