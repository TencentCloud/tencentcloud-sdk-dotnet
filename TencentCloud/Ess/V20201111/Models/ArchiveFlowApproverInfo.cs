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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ArchiveFlowApproverInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>个人签署人姓名，如果传入，必须是证件上的真实中文名；中文名最长 25 个字符；</p>
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// <p>参与者类型，用于区分个人或企业，可选类型如下:<br><strong>0</strong>：企业<br><strong>1</strong>：个人</p>
        /// </summary>
        [JsonProperty("ApproverType")]
        public long? ApproverType{ get; set; }

        /// <summary>
        /// <p>企业签署方名称。长度不超过 200 个字符。<br>如果名称中包含英文括号()，请使用中文括号（）代替。<br>如果签署方是企业签署方(approverType = 0 )， 则企业名称必填。</p>
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// <p>签署人手机号，必须是合法手机号。</p>
        /// </summary>
        [JsonProperty("ApproverMobile")]
        public string ApproverMobile{ get; set; }

        /// <summary>
        /// <p>签署人邮箱， 必须是合法邮箱格式。</p>
        /// </summary>
        [JsonProperty("ApproverEmail")]
        public string ApproverEmail{ get; set; }

        /// <summary>
        /// <p>签署方经办人的证件类型，支持以下类型，样式可以参考<a href="https://qian.tencent.com/developers/partner/id_card_support/" target="_blank">常见个人证件类型介绍</a></p><ul><li>ID_CARD 中国大陆居民身份证  (默认值)</li><li>HONGKONG_AND_MACAO 港澳居民来往内地通行证</li><li>HONGKONG_MACAO_AND_TAIWAN 港澳台居民居住证(格式同居民身份证)</li><li>OTHER_CARD_TYPE 其他证件</li></ul>
        /// </summary>
        [JsonProperty("ApproverIdCardType")]
        public string ApproverIdCardType{ get; set; }

        /// <summary>
        /// <p>签署方经办人的证件号码，应符合以下规则</p><ul><li>中国大陆居民身份证号码应为18位字符串，由数字和大写字母X组成（如存在X，请大写）。</li><li>中国港澳居民来往内地通行证号码共11位。第1位为字母，“H”字头签发给中国香港居民，“M”字头签发给中国澳门居民；第2位至第11位为数字。</li><li>中国港澳台居民居住证号码编码规则与中国大陆身份证相同，应为18位字符串。</li></ul>
        /// </summary>
        [JsonProperty("ApproverIdCardNumber")]
        public string ApproverIdCardNumber{ get; set; }

        /// <summary>
        /// <p>当前参与者的签署时间，Unix 秒级时间戳。</p>
        /// </summary>
        [JsonProperty("ApproveTime")]
        public long? ApproveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "ApproverMobile", this.ApproverMobile);
            this.SetParamSimple(map, prefix + "ApproverEmail", this.ApproverEmail);
            this.SetParamSimple(map, prefix + "ApproverIdCardType", this.ApproverIdCardType);
            this.SetParamSimple(map, prefix + "ApproverIdCardNumber", this.ApproverIdCardNumber);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
        }
    }
}

