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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("IotAppID")]
        public string IotAppID{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 应用说明
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 关联的产品
        /// </summary>
        [JsonProperty("Products")]
        public string Products{ get; set; }

        /// <summary>
        /// 信鸽推送APP ID
        /// </summary>
        [JsonProperty("PushSecretID")]
        public string PushSecretID{ get; set; }

        /// <summary>
        /// 信鸽推送SECRET KEY
        /// </summary>
        [JsonProperty("PushSecretKey")]
        public string PushSecretKey{ get; set; }

        /// <summary>
        /// iOS平台推送环境
        /// </summary>
        [JsonProperty("PushEnvironment")]
        public string PushEnvironment{ get; set; }

        /// <summary>
        /// TPNS服务iOS应用AccessID，TPNS全称为腾讯移动推送（Tencent Push Notification Service），详见：https://cloud.tencent.com/document/product/548
        /// </summary>
        [JsonProperty("TPNSiOSAccessID")]
        public string TPNSiOSAccessID{ get; set; }

        /// <summary>
        /// TPNS服务iOS应用SecretKey
        /// </summary>
        [JsonProperty("TPNSiOSSecretKey")]
        public string TPNSiOSSecretKey{ get; set; }

        /// <summary>
        /// TPNS服务iOS应用推送环境
        /// </summary>
        [JsonProperty("TPNSiOSPushEnvironment")]
        public string TPNSiOSPushEnvironment{ get; set; }

        /// <summary>
        /// TPNS服务Android应用AccessID
        /// </summary>
        [JsonProperty("TPNSAndroidAccessID")]
        public string TPNSAndroidAccessID{ get; set; }

        /// <summary>
        /// TPNS服务Android应用SecretKey
        /// </summary>
        [JsonProperty("TPNSAndroidSecretKey")]
        public string TPNSAndroidSecretKey{ get; set; }

        /// <summary>
        /// TPNS服务iOS应用所属地域，广州：ap-guangzhou，上海：ap-shanghai，中国香港：ap-hongkong，新加坡：ap-singapore。
        /// </summary>
        [JsonProperty("TPNSiOSRegion")]
        public string TPNSiOSRegion{ get; set; }

        /// <summary>
        /// TPNS服务Android应用所属地域，广州：ap-guangzhou，上海：ap-shanghai，中国香港：ap-hongkong，新加坡：ap-singapore。
        /// </summary>
        [JsonProperty("TPNSAndroidRegion")]
        public string TPNSAndroidRegion{ get; set; }

        /// <summary>
        /// TurnKey小程序托管
        /// </summary>
        [JsonProperty("TurnKeySwitch")]
        public long? TurnKeySwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IotAppID", this.IotAppID);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Products", this.Products);
            this.SetParamSimple(map, prefix + "PushSecretID", this.PushSecretID);
            this.SetParamSimple(map, prefix + "PushSecretKey", this.PushSecretKey);
            this.SetParamSimple(map, prefix + "PushEnvironment", this.PushEnvironment);
            this.SetParamSimple(map, prefix + "TPNSiOSAccessID", this.TPNSiOSAccessID);
            this.SetParamSimple(map, prefix + "TPNSiOSSecretKey", this.TPNSiOSSecretKey);
            this.SetParamSimple(map, prefix + "TPNSiOSPushEnvironment", this.TPNSiOSPushEnvironment);
            this.SetParamSimple(map, prefix + "TPNSAndroidAccessID", this.TPNSAndroidAccessID);
            this.SetParamSimple(map, prefix + "TPNSAndroidSecretKey", this.TPNSAndroidSecretKey);
            this.SetParamSimple(map, prefix + "TPNSiOSRegion", this.TPNSiOSRegion);
            this.SetParamSimple(map, prefix + "TPNSAndroidRegion", this.TPNSAndroidRegion);
            this.SetParamSimple(map, prefix + "TurnKeySwitch", this.TurnKeySwitch);
        }
    }
}

