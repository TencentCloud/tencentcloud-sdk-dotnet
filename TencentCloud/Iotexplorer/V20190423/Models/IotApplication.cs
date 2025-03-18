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

    public class IotApplication : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID
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
        /// 开发模式
        /// </summary>
        [JsonProperty("DevMode")]
        public long? DevMode{ get; set; }

        /// <summary>
        /// iOS 平台 AppKey
        /// </summary>
        [JsonProperty("IOSAppKey")]
        public string IOSAppKey{ get; set; }

        /// <summary>
        /// iOS 平台 AppSecret
        /// </summary>
        [JsonProperty("IOSAppSecret")]
        public string IOSAppSecret{ get; set; }

        /// <summary>
        /// Android 平台 AppKey
        /// </summary>
        [JsonProperty("AndroidAppKey")]
        public string AndroidAppKey{ get; set; }

        /// <summary>
        /// Android 平台 AppSecret
        /// </summary>
        [JsonProperty("AndroidAppSecret")]
        public string AndroidAppSecret{ get; set; }

        /// <summary>
        /// 绑定的产品列表，数据为：ProdcutID 数组 JSON 序列化后的字符串
        /// </summary>
        [JsonProperty("Products")]
        public string Products{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

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
        /// 小程序平台 AppKey
        /// </summary>
        [JsonProperty("MiniProgramAppKey")]
        public string MiniProgramAppKey{ get; set; }

        /// <summary>
        /// 小程序平台 AppSecret
        /// </summary>
        [JsonProperty("MiniProgramAppSecret")]
        public string MiniProgramAppSecret{ get; set; }

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
        /// TPNS服务iOS应用所属地域，详细说明参见 ModifyApplication 同名入参。
        /// </summary>
        [JsonProperty("TPNSiOSRegion")]
        public string TPNSiOSRegion{ get; set; }

        /// <summary>
        /// TPNS服务Android应用所属地域，详细说明参见 ModifyApplication 同名入参。
        /// </summary>
        [JsonProperty("TPNSAndroidRegion")]
        public string TPNSAndroidRegion{ get; set; }

        /// <summary>
        /// 自主短信配置APPID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfSmsAppId")]
        public string SelfSmsAppId{ get; set; }

        /// <summary>
        /// 自主短信配置APPKey
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfSmsAppKey")]
        public string SelfSmsAppKey{ get; set; }

        /// <summary>
        /// 自主短信配置签名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfSmsSign")]
        public string SelfSmsSign{ get; set; }

        /// <summary>
        /// 自主短信配置模板ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfSmsTemplateId")]
        public long? SelfSmsTemplateId{ get; set; }

        /// <summary>
        /// 第三方小程序强提醒开关 0：关闭；1：开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatNotifyStatus")]
        public long? WechatNotifyStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IotAppID", this.IotAppID);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DevMode", this.DevMode);
            this.SetParamSimple(map, prefix + "IOSAppKey", this.IOSAppKey);
            this.SetParamSimple(map, prefix + "IOSAppSecret", this.IOSAppSecret);
            this.SetParamSimple(map, prefix + "AndroidAppKey", this.AndroidAppKey);
            this.SetParamSimple(map, prefix + "AndroidAppSecret", this.AndroidAppSecret);
            this.SetParamSimple(map, prefix + "Products", this.Products);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PushSecretID", this.PushSecretID);
            this.SetParamSimple(map, prefix + "PushSecretKey", this.PushSecretKey);
            this.SetParamSimple(map, prefix + "PushEnvironment", this.PushEnvironment);
            this.SetParamSimple(map, prefix + "MiniProgramAppKey", this.MiniProgramAppKey);
            this.SetParamSimple(map, prefix + "MiniProgramAppSecret", this.MiniProgramAppSecret);
            this.SetParamSimple(map, prefix + "TPNSiOSAccessID", this.TPNSiOSAccessID);
            this.SetParamSimple(map, prefix + "TPNSiOSSecretKey", this.TPNSiOSSecretKey);
            this.SetParamSimple(map, prefix + "TPNSiOSPushEnvironment", this.TPNSiOSPushEnvironment);
            this.SetParamSimple(map, prefix + "TPNSAndroidAccessID", this.TPNSAndroidAccessID);
            this.SetParamSimple(map, prefix + "TPNSAndroidSecretKey", this.TPNSAndroidSecretKey);
            this.SetParamSimple(map, prefix + "TPNSiOSRegion", this.TPNSiOSRegion);
            this.SetParamSimple(map, prefix + "TPNSAndroidRegion", this.TPNSAndroidRegion);
            this.SetParamSimple(map, prefix + "SelfSmsAppId", this.SelfSmsAppId);
            this.SetParamSimple(map, prefix + "SelfSmsAppKey", this.SelfSmsAppKey);
            this.SetParamSimple(map, prefix + "SelfSmsSign", this.SelfSmsSign);
            this.SetParamSimple(map, prefix + "SelfSmsTemplateId", this.SelfSmsTemplateId);
            this.SetParamSimple(map, prefix + "WechatNotifyStatus", this.WechatNotifyStatus);
        }
    }
}

