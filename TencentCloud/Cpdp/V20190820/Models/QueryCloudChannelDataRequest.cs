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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryCloudChannelDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 米大师分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 业务订单号，外部订单号
        /// </summary>
        [JsonProperty("OutOrderNo")]
        public string OutOrderNo{ get; set; }

        /// <summary>
        /// 数据类型
        /// PAYMENT:支付
        /// </summary>
        [JsonProperty("ExternalChannelDataType")]
        public string ExternalChannelDataType{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 子应用ID
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 渠道名称，指定渠道查询
        /// wechat:微信支付
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "OutOrderNo", this.OutOrderNo);
            this.SetParamSimple(map, prefix + "ExternalChannelDataType", this.ExternalChannelDataType);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
        }
    }
}

