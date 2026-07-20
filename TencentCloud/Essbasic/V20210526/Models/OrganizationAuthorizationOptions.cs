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

    public class OrganizationAuthorizationOptions : AbstractModel
    {
        
        /// <summary>
        /// <p>对方打开链接认证时，对方填写的营业执照的社会信用代码是否与接口上传上来的要保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul></p>
        /// </summary>
        [JsonProperty("UniformSocialCreditCodeSame")]
        public bool? UniformSocialCreditCodeSame{ get; set; }

        /// <summary>
        /// <p>对方打开链接认证时，企业名称是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>p.s. 仅在企业名称不为空时有效</p>
        /// </summary>
        [JsonProperty("OrganizationNameSame")]
        public bool? OrganizationNameSame{ get; set; }

        /// <summary>
        /// <p>对方打开链接认证时，法人姓名是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>p.s. 仅在法人姓名不为空时有效</p>
        /// </summary>
        [JsonProperty("LegalNameSame")]
        public bool? LegalNameSame{ get; set; }

        /// <summary>
        /// <p>对方打开链接认证时，对公打款账号是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>p.s. 仅在对公打款账号不为空时有效</p>
        /// </summary>
        [JsonProperty("BankAccountNumberSame")]
        public bool? BankAccountNumberSame{ get; set; }

        /// <summary>
        /// <p>对方打开链接认证时，公司地址是否要与接口传递上来的保持一致。</p><ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时会回显接口传递的值，且不可更改</li></ul>p.s. 仅在公司地址（ProxyAddress）不为空时有效如下图所示：<img src="https://qcloudimg.tencent-cloud.cn/raw/4aa67a434cdf522c04e32f2e1de0382b.png" alt="示例"><p></p>
        /// </summary>
        [JsonProperty("AddressSame")]
        public bool? AddressSame{ get; set; }

        /// <summary>
        /// <p>对方打开链接认证时，公司营业执照是否要与接口传递上来的保持一致。</p><ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致，用户可以进行修改</li><li><b>true</b>：启用状态，实际认证时回填的信息就是用户传递的值，并且不能修改</li></ul><p></p><p>p.s. 仅在公司营业执照（BusinessLicense）不为空时有效</p>如下图<img src="https://qcloudimg.tencent-cloud.cn/raw/7159637d5a8ac3d92b35813b1fc9660a.png" alt="示例">
        /// </summary>
        [JsonProperty("BizLicenseSame")]
        public bool? BizLicenseSame{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniformSocialCreditCodeSame", this.UniformSocialCreditCodeSame);
            this.SetParamSimple(map, prefix + "OrganizationNameSame", this.OrganizationNameSame);
            this.SetParamSimple(map, prefix + "LegalNameSame", this.LegalNameSame);
            this.SetParamSimple(map, prefix + "BankAccountNumberSame", this.BankAccountNumberSame);
            this.SetParamSimple(map, prefix + "AddressSame", this.AddressSame);
            this.SetParamSimple(map, prefix + "BizLicenseSame", this.BizLicenseSame);
        }
    }
}

