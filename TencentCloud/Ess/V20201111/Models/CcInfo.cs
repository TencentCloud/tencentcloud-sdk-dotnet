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

    public class CcInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>被抄送方手机号码， 支持中国大陆手机号11位数字(无需加+86前缀或其他字符)。<br>请确认手机号所有方为此业务通知方。</p>
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// <p>被抄送方姓名。<br>抄送方的姓名将用于身份认证，请确保填写的姓名为抄送方的真实姓名，而非昵称等代名。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>被抄送方类型, 可设置以下类型:</p><ul><li> **0** :个人抄送方</li><li> **1** :企业员工抄送方</li></ul>
        /// </summary>
        [JsonProperty("CcType")]
        public long? CcType{ get; set; }

        /// <summary>
        /// <p>被抄送方权限, 可设置如下权限:</p><ul><li> **0** :可查看合同内容</li><li> **1** :可查看合同内容也可下载原文</li></ul>
        /// </summary>
        [JsonProperty("CcPermission")]
        public long? CcPermission{ get; set; }

        /// <summary>
        /// <p>通知签署方经办人的方式,  有以下途径:</p><ul><li> **sms** :  (默认)短信</li><li> **none** : 不通知</li></ul>
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// <p>被抄送方企业名称。<br>请确认该名称与企业营业执照中注册的名称一致。<br>如果名称中包含英文括号()，请使用中文括号（）代替。</p><p>注意:<br><font color="red">此为白名单功能，需要联系客户经理，开通白名单后才能使用。</font><br>使用文档 <a href="https://qian.tencent.com/developers/company/enterprise_inbox">签署方/抄送方仅指定企业名称发起合同</a></p>
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CcType", this.CcType);
            this.SetParamSimple(map, prefix + "CcPermission", this.CcPermission);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
        }
    }
}

