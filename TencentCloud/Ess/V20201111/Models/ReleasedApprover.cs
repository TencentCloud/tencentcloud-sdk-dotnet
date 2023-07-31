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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleasedApprover : AbstractModel
    {
        
        /// <summary>
        /// 签署人姓名，最大长度50个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 签署人手机号
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 要替换的参与人在原合同参与人列表中的签署人编号,通过DescribeFlowInfo 接口获取（即FlowDetailInfos. FlowApproverInfos 结构中的ReceiptId ）
        /// </summary>
        [JsonProperty("RelievedApproverReceiptId")]
        public string RelievedApproverReceiptId{ get; set; }

        /// <summary>
        /// 指定签署人类型，目前仅支持
        /// ORGANIZATION-企业
        /// ENTERPRISESERVER-企业静默签
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 签署控件类型，支持自定义企业签署方的签署控件为“印章”或“签名”
        /// - SIGN_SEAL-默认为印章控件类型
        /// - SIGN_SIGNATURE-手写签名控件类型
        /// </summary>
        [JsonProperty("ApproverSignComponentType")]
        public string ApproverSignComponentType{ get; set; }

        /// <summary>
        /// 参与方在合同中的角色是按照创建合同的时候来排序的; 解除协议会将第一个参与人叫甲方, 第二个叫乙方,第三个叫丙方, 依次类推.  如果想改动参与人的角色名字, 可以设置此签署方自定义控件别名字段，最大20个字符
        /// </summary>
        [JsonProperty("ApproverSignRole")]
        public string ApproverSignRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "RelievedApproverReceiptId", this.RelievedApproverReceiptId);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "ApproverSignComponentType", this.ApproverSignComponentType);
            this.SetParamSimple(map, prefix + "ApproverSignRole", this.ApproverSignRole);
        }
    }
}

