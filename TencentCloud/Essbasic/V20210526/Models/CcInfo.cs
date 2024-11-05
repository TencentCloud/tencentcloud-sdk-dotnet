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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcInfo : AbstractModel
    {
        
        /// <summary>
        /// 被抄送方手机号码， 支持国内手机号11位数字(无需加+86前缀或其他字符)。
        /// 请确认手机号所有方为此业务通知方。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 被抄送方姓名。
        /// 抄送方的姓名将用于身份认证，请确保填写的姓名为抄送方的真实姓名，而非昵称等代名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 被抄送方类型, 可设置以下类型:
        /// <ul><li> **0** :个人抄送方</li>
        /// <li> **1** :企业员工抄送方</li></ul>
        /// </summary>
        [JsonProperty("CcType")]
        public long? CcType{ get; set; }

        /// <summary>
        /// 被抄送方权限, 可设置如下权限:
        /// <ul><li> **0** :可查看合同内容</li>
        /// <li> **1** :可查看合同内容也可下载原文</li></ul>
        /// </summary>
        [JsonProperty("CcPermission")]
        public long? CcPermission{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CcType", this.CcType);
            this.SetParamSimple(map, prefix + "CcPermission", this.CcPermission);
        }
    }
}

