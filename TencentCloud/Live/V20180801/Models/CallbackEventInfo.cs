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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallbackEventInfo : AbstractModel
    {
        
        /// <summary>
        /// 事件时间。
        /// 接口返回支持两种时间格式：
        /// 1）YYYY-MM-DDThh:mm:ssZ：UTC时间格式，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)
        /// 2）yyyy-MM-dd HH:mm:ss：使用此格式时，默认代表北京时间。
        /// 接口返回的时间格式和查询请求传入的时间格式一致。
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// 事件类型。
        /// </summary>
        [JsonProperty("EventType")]
        public ulong? EventType{ get; set; }

        /// <summary>
        /// 回调请求。
        /// </summary>
        [JsonProperty("Request")]
        public string Request{ get; set; }

        /// <summary>
        /// 回调响应。
        /// </summary>
        [JsonProperty("Response")]
        public string Response{ get; set; }

        /// <summary>
        /// 客户接口响应时间。
        /// 接口返回支持两种时间格式：
        /// 1）YYYY-MM-DDThh:mm:ssZ：UTC时间格式，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)
        /// 2）yyyy-MM-dd HH:mm:ss：使用此格式时，默认代表北京时间。
        /// 接口返回的时间格式和查询请求传入的时间格式一致。
        /// </summary>
        [JsonProperty("ResponseTime")]
        public string ResponseTime{ get; set; }

        /// <summary>
        /// 回调结果。
        /// </summary>
        [JsonProperty("ResultCode")]
        public ulong? ResultCode{ get; set; }

        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Request", this.Request);
            this.SetParamSimple(map, prefix + "Response", this.Response);
            this.SetParamSimple(map, prefix + "ResponseTime", this.ResponseTime);
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
        }
    }
}

