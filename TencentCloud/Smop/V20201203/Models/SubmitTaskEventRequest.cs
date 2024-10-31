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

namespace TencentCloud.Smop.V20201203.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitTaskEventRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户唯一标识，最大长度为64
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// 用户设备ID，最大长度为64
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 任务的唯一订单号，只能是数字、大小写字母，且在同一个产品ID下唯一，最大长度为64
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 任务事件Code，在腾讯安心用户运营平台下的任务事件列表中设置并获取
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 任务结果是否异步通知。0表示任务结果在返回信息中同步返回；1表示任务结果通过回调结果异步通知。
        /// </summary>
        [JsonProperty("Async")]
        public long? Async{ get; set; }

        /// <summary>
        /// 产品ID，可在腾讯安心用户运营平台的企业管理中获取
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// 异步接收任务结果通知的回调地址。在Async为1的时候，会将任务结果通过该回调地址进行通知。
        /// </summary>
        [JsonProperty("NotifyURL")]
        public string NotifyURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Async", this.Async);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "NotifyURL", this.NotifyURL);
        }
    }
}

