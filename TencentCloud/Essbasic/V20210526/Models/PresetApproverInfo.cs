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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PresetApproverInfo : AbstractModel
    {
        
        /// <summary>
        /// 预设参与方姓名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 预设参与方手机号。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 预设参与方证件号，需要和IdCardType同时传入。
        /// 
        /// 证件号码，应符合以下规则
        /// <ul><li>中国大陆居民身份证号码应为18位字符串，由数字和大写字母X组成(如存在X，请大写)。</li></ul>
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 预设参与方的证件类型，需要与IdCardNumber同时传入。
        /// 
        /// 证件类型，支持以下类型
        /// <ul><li><b>ID_CARD</b>: 居民身份证</li></ul>
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
        }
    }
}

