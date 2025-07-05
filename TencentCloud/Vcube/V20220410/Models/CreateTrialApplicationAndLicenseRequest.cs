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

namespace TencentCloud.Vcube.V20220410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTrialApplicationAndLicenseRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// 包名
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// 功能 id 数组
        /// </summary>
        [JsonProperty("FeatureIds")]
        public long?[] FeatureIds{ get; set; }

        /// <summary>
        /// 是否要开通优图功能
        /// </summary>
        [JsonProperty("XMagic")]
        public bool? XMagic{ get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [JsonProperty("CompanyPermit")]
        public string CompanyPermit{ get; set; }

        /// <summary>
        /// 公司类型
        /// </summary>
        [JsonProperty("CompanyType")]
        public string CompanyType{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 要开通的测试功能名称，基础套餐只能有一个
        /// </summary>
        [JsonProperty("PlanList")]
        public string[] PlanList{ get; set; }

        /// <summary>
        /// Mac 进程名
        /// </summary>
        [JsonProperty("MacBundleId")]
        public string MacBundleId{ get; set; }

        /// <summary>
        /// Windows 进程名
        /// </summary>
        [JsonProperty("WinProcessName")]
        public string WinProcessName{ get; set; }

        /// <summary>
        /// 要创建到哪个平台，web、mobile、pc，默认mobile
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 授权域名列表
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamArraySimple(map, prefix + "FeatureIds.", this.FeatureIds);
            this.SetParamSimple(map, prefix + "XMagic", this.XMagic);
            this.SetParamSimple(map, prefix + "CompanyPermit", this.CompanyPermit);
            this.SetParamSimple(map, prefix + "CompanyType", this.CompanyType);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamArraySimple(map, prefix + "PlanList.", this.PlanList);
            this.SetParamSimple(map, prefix + "MacBundleId", this.MacBundleId);
            this.SetParamSimple(map, prefix + "WinProcessName", this.WinProcessName);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
        }
    }
}

