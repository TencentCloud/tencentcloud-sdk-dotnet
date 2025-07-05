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

namespace TencentCloud.Mmps.V20200710.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlySecMiniAppProfessionalScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 小程序AppID
        /// </summary>
        [JsonProperty("MiniAppID")]
        public string MiniAppID{ get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonProperty("MiniAppName")]
        public string MiniAppName{ get; set; }

        /// <summary>
        /// 诊断模式 2:深度诊断
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("CorpName")]
        public string CorpName{ get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MiniAppID", this.MiniAppID);
            this.SetParamSimple(map, prefix + "MiniAppName", this.MiniAppName);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "CorpName", this.CorpName);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

