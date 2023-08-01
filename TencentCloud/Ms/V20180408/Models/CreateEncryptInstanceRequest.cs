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

    public class CreateEncryptInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台类型  1.android加固   2.ios源码混淆  3.sdk加固  4.applet小程序加固
        /// </summary>
        [JsonProperty("PlatformType")]
        public long? PlatformType{ get; set; }

        /// <summary>
        /// 订单采购类型 1-免费试用 2-按年收费 3-按次收费
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 1-在线加固、  2-输出工具加固
        /// </summary>
        [JsonProperty("EncryptOpType")]
        public long? EncryptOpType{ get; set; }

        /// <summary>
        /// 本次加固使用的资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 渠道合作android加固App信息 
        /// </summary>
        [JsonProperty("AndroidAppInfo")]
        public AndroidAppInfo AndroidAppInfo{ get; set; }

        /// <summary>
        /// 渠道合作android加固策略信息
        /// </summary>
        [JsonProperty("AndroidPlan")]
        public AndroidPlan AndroidPlan{ get; set; }

        /// <summary>
        /// 小程序加固信息
        /// </summary>
        [JsonProperty("AppletInfo")]
        public AppletInfo AppletInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "EncryptOpType", this.EncryptOpType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "AndroidAppInfo.", this.AndroidAppInfo);
            this.SetParamObj(map, prefix + "AndroidPlan.", this.AndroidPlan);
            this.SetParamObj(map, prefix + "AppletInfo.", this.AppletInfo);
        }
    }
}

