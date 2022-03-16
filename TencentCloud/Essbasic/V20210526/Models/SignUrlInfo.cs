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

    public class SignUrlInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignUrl")]
        public string SignUrl{ get; set; }

        /// <summary>
        /// 链接失效时间,默认30分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 当流程为顺序签署此参数有效时，数字越小优先级越高，暂不支持并行签署 可选
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignOrder")]
        public long? SignOrder{ get; set; }

        /// <summary>
        /// 签署人编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// 自定义用户编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomUserId")]
        public string CustomUserId{ get; set; }

        /// <summary>
        /// 用户姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户手机号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 签署参与者机构名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 参与者类型:
        /// ORGANIZATION 企业经办人
        /// PERSON 自然人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 经办人身份证号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 签署链接对应流程Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 企业经办人 用户在渠道的编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignUrl", this.SignUrl);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "SignOrder", this.SignOrder);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "CustomUserId", this.CustomUserId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
        }
    }
}

