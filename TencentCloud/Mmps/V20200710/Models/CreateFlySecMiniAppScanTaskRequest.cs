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

namespace TencentCloud.Mmps.V20200710.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlySecMiniAppScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 小程序AppID
        /// </summary>
        [JsonProperty("MiniAppID")]
        public string MiniAppID{ get; set; }

        /// <summary>
        /// 诊断模式 1:基础诊断，2:深度诊断
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 小程序测试账号(自有账号体系需提供,其他情况不需要)
        /// </summary>
        [JsonProperty("MiniAppTestAccount")]
        public string MiniAppTestAccount{ get; set; }

        /// <summary>
        /// 小程序测试密码(自有账号体系需提供,其他情况不需要)
        /// </summary>
        [JsonProperty("MiniAppTestPwd")]
        public string MiniAppTestPwd{ get; set; }

        /// <summary>
        /// 小程序所属行业
        /// </summary>
        [JsonProperty("Industry")]
        public string Industry{ get; set; }

        /// <summary>
        /// 小程序调查问卷json字符串
        /// </summary>
        [JsonProperty("SurveyContent")]
        public string SurveyContent{ get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 商务合作接口人
        /// </summary>
        [JsonProperty("SalesPerson")]
        public string SalesPerson{ get; set; }

        /// <summary>
        /// 诊断扫描版本 0:正式版 1:体验版
        /// </summary>
        [JsonProperty("ScanVersion")]
        public long? ScanVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MiniAppID", this.MiniAppID);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "MiniAppTestAccount", this.MiniAppTestAccount);
            this.SetParamSimple(map, prefix + "MiniAppTestPwd", this.MiniAppTestPwd);
            this.SetParamSimple(map, prefix + "Industry", this.Industry);
            this.SetParamSimple(map, prefix + "SurveyContent", this.SurveyContent);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "SalesPerson", this.SalesPerson);
            this.SetParamSimple(map, prefix + "ScanVersion", this.ScanVersion);
        }
    }
}

