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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EncryptResults : AbstractModel
    {
        
        /// <summary>
        /// 平台类型枚举值  1-android加固   2-ios源码混淆  3-sdk加固  4-applet小程序加固
        /// </summary>
        [JsonProperty("PlatformType")]
        public long? PlatformType{ get; set; }

        /// <summary>
        /// 平台类型描述  1-android加固   2-ios源码混淆  3-sdk加固  4-applet小程序加固
        /// </summary>
        [JsonProperty("PlatformDesc")]
        public string PlatformDesc{ get; set; }

        /// <summary>
        /// 订单采购类型枚举值， 1-免费试用 2-按年收费 3-按次收费
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 订单采购类型 描述：1-免费试用 2-按年收费 3-按次收费
        /// </summary>
        [JsonProperty("OrderTypeDesc")]
        public string OrderTypeDesc{ get; set; }

        /// <summary>
        /// 枚举值：1-在线加固 或 2-输出工具加固
        /// </summary>
        [JsonProperty("EncryptOpType")]
        public long? EncryptOpType{ get; set; }

        /// <summary>
        /// 描述：1-在线加固 或 2-输出工具加固
        /// </summary>
        [JsonProperty("EncryptOpTypeDesc")]
        public string EncryptOpTypeDesc{ get; set; }

        /// <summary>
        /// 与当前任务关联的资源Id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 与当前任务关联的订单Id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 对应PlatformType平台类型值   1-android加固结果
        /// </summary>
        [JsonProperty("AndroidResult")]
        public AndroidResult AndroidResult{ get; set; }

        /// <summary>
        /// 对应PlatformType平台类型值   2-ios源码混淆加固结果
        /// </summary>
        [JsonProperty("IOSResult")]
        public IOSResult IOSResult{ get; set; }

        /// <summary>
        /// 对应PlatformType平台类型值   3-sdk加固结果
        /// </summary>
        [JsonProperty("SDKResult")]
        public SDKResult SDKResult{ get; set; }

        /// <summary>
        /// 对应PlatformType平台类型值   4-applet小程序加固结果
        /// </summary>
        [JsonProperty("AppletResult")]
        public AppletResult AppletResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "PlatformDesc", this.PlatformDesc);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "OrderTypeDesc", this.OrderTypeDesc);
            this.SetParamSimple(map, prefix + "EncryptOpType", this.EncryptOpType);
            this.SetParamSimple(map, prefix + "EncryptOpTypeDesc", this.EncryptOpTypeDesc);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamObj(map, prefix + "AndroidResult.", this.AndroidResult);
            this.SetParamObj(map, prefix + "IOSResult.", this.IOSResult);
            this.SetParamObj(map, prefix + "SDKResult.", this.SDKResult);
            this.SetParamObj(map, prefix + "AppletResult.", this.AppletResult);
        }
    }
}

