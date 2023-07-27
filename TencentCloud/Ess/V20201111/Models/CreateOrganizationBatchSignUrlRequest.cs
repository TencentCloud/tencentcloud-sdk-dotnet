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

    public class CreateOrganizationBatchSignUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，UserId 必填，支持填入集团子公司经办人UserId。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 指定需要进行批量签署的流程id，数量1-100，填写后用户将通过链接对这些合同进行批量签署。
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 员工的UserId，该UserId对应的员工必须已经加入企业并实名，Name和Mobile为空时该字段不能为空。（优先使用UserId对应的员工）
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 员工姓名，该字段需要与Mobile组合使用，UserId为空时该字段不能为空。（UserId为空时，使用Name和Mbile对应的员工）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 员工手机号码，该字段需要与Name组合使用，UserId为空时该字段不能为空。（UserId为空时，使用Name和Mbile对应的员工）
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
        }
    }
}

