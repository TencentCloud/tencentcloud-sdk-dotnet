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

    public class ExtendAuthInfo : AbstractModel
    {
        
        /// <summary>
        /// 扩展服务的类型，可能是以下值：
        /// <ul><li>OPEN_SERVER_SIGN：企业自动签署</li>
        /// <li>BATCH_SIGN：批量签署</li>
        /// <li>OVERSEA_SIGN：企业与港澳台居民签署合同</li>
        /// <li>AGE_LIMIT_EXPANSION：拓宽签署方年龄限制</li>
        /// <li>MOBILE_CHECK_APPROVER：个人签署方仅校验手机号</li>
        /// <li>HIDE_OPERATOR_DISPLAY：隐藏合同经办人姓名</li>
        /// <li>ORGANIZATION_OCR_FALLBACK：正楷临摹签名失败后更换其他签名类型</li>
        /// <li>ORGANIZATION_FLOW_NOTIFY_TYPE：短信通知签署方</li>
        /// <li>HIDE_ONE_KEY_SIGN：个人签署方手动签字</li>
        /// <li>PAGING_SEAL：骑缝章</li>
        /// <li>ORGANIZATION_FLOW_PASSWD_NOTIFY：签署密码开通引导</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 扩展服务的名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 扩展服务的开通状态：
        /// <ul>
        /// <li>ENABLE : 已开通</li>
        /// <li>DISABLE : 未开通</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 操作扩展服务的操作人UserId，员工在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// </summary>
        [JsonProperty("OperatorUserId")]
        public string OperatorUserId{ get; set; }

        /// <summary>
        /// 扩展服务的操作时间，格式为Unix标准时间戳（秒）。
        /// </summary>
        [JsonProperty("OperateOn")]
        public long? OperateOn{ get; set; }

        /// <summary>
        /// 该扩展服务若可以授权，此参数对应授权人员的列表
        /// </summary>
        [JsonProperty("HasAuthUserList")]
        public HasAuthUser[] HasAuthUserList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OperatorUserId", this.OperatorUserId);
            this.SetParamSimple(map, prefix + "OperateOn", this.OperateOn);
            this.SetParamArrayObj(map, prefix + "HasAuthUserList.", this.HasAuthUserList);
        }
    }
}

