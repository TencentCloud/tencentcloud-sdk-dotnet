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

namespace TencentCloud.Acp.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppInfoItem : AbstractModel
    {
        
        /// <summary>
        /// App包名
        /// </summary>
        [JsonProperty("AppPackage")]
        public string AppPackage{ get; set; }

        /// <summary>
        /// App名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// App版本
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 应用平台, 0:android, 1:ios, 2:小程序
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }

        /// <summary>
        /// App隐私诊断报告下载链接
        /// </summary>
        [JsonProperty("ReportUrl")]
        public string ReportUrl{ get; set; }

        /// <summary>
        /// App隐私诊断报告名称
        /// </summary>
        [JsonProperty("ReportTitle")]
        public string ReportTitle{ get; set; }

        /// <summary>
        /// App诊断堆栈报告下载链接
        /// </summary>
        [JsonProperty("BehaviorUrl")]
        public string BehaviorUrl{ get; set; }

        /// <summary>
        /// App诊断堆栈报告名称
        /// </summary>
        [JsonProperty("BehaviorTitle")]
        public string BehaviorTitle{ get; set; }

        /// <summary>
        /// 诊断高风险项数量
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public long? HighRiskCount{ get; set; }

        /// <summary>
        /// 隐私申明文件名称
        /// </summary>
        [JsonProperty("PrivacyTextName")]
        public string PrivacyTextName{ get; set; }

        /// <summary>
        /// 软件MD5
        /// </summary>
        [JsonProperty("SoftwareMD5")]
        public string SoftwareMD5{ get; set; }

        /// <summary>
        /// 隐私文本MD5
        /// </summary>
        [JsonProperty("PrivacyTextMD5")]
        public string PrivacyTextMD5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppPackage", this.AppPackage);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ReportUrl", this.ReportUrl);
            this.SetParamSimple(map, prefix + "ReportTitle", this.ReportTitle);
            this.SetParamSimple(map, prefix + "BehaviorUrl", this.BehaviorUrl);
            this.SetParamSimple(map, prefix + "BehaviorTitle", this.BehaviorTitle);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "PrivacyTextName", this.PrivacyTextName);
            this.SetParamSimple(map, prefix + "SoftwareMD5", this.SoftwareMD5);
            this.SetParamSimple(map, prefix + "PrivacyTextMD5", this.PrivacyTextMD5);
        }
    }
}

