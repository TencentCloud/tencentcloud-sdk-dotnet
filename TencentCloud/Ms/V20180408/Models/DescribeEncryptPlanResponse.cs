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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEncryptPlanResponse : AbstractModel
    {
        
        /// <summary>
        /// 平台类型整型值  
        /// </summary>
        [JsonProperty("PlatformType")]
        public long? PlatformType{ get; set; }

        /// <summary>
        /// 平台类型描述 1.android加固   2.ios源码混淆  3.sdk加固  4.applet小程序加固
        /// </summary>
        [JsonProperty("PlatformTypeDesc")]
        public string PlatformTypeDesc{ get; set; }

        /// <summary>
        /// 1- 在线加固 2-输出工具加固
        /// </summary>
        [JsonProperty("EncryptOpType")]
        public long? EncryptOpType{ get; set; }

        /// <summary>
        /// 1- 在线加固 2-输出工具加固
        /// </summary>
        [JsonProperty("EncryptOpTypeDesc")]
        public string EncryptOpTypeDesc{ get; set; }

        /// <summary>
        /// 订单收费类型枚举值
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 订单收费类型描述
        /// </summary>
        [JsonProperty("OrderTypeDesc")]
        public string OrderTypeDesc{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 上次加固策略
        /// </summary>
        [JsonProperty("AndroidPlan")]
        public AndroidPlan AndroidPlan{ get; set; }

        /// <summary>
        /// 上次小程序加固策略
        /// </summary>
        [JsonProperty("AppletPlan")]
        public AppletPlan AppletPlan{ get; set; }

        /// <summary>
        /// 上次ios源码混淆加固配置
        /// </summary>
        [JsonProperty("IOSPlan")]
        public IOSPlan IOSPlan{ get; set; }

        /// <summary>
        /// 上次sdk加固配置
        /// </summary>
        [JsonProperty("SDKPlan")]
        public SDKPlan SDKPlan{ get; set; }

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
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "PlatformTypeDesc", this.PlatformTypeDesc);
            this.SetParamSimple(map, prefix + "EncryptOpType", this.EncryptOpType);
            this.SetParamSimple(map, prefix + "EncryptOpTypeDesc", this.EncryptOpTypeDesc);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "OrderTypeDesc", this.OrderTypeDesc);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "AndroidPlan.", this.AndroidPlan);
            this.SetParamObj(map, prefix + "AppletPlan.", this.AppletPlan);
            this.SetParamObj(map, prefix + "IOSPlan.", this.IOSPlan);
            this.SetParamObj(map, prefix + "SDKPlan.", this.SDKPlan);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

