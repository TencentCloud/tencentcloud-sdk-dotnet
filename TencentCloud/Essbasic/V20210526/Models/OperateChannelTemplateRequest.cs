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

    public class OperateChannelTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 和 Agent.ProxyAppId 均必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 渠道方模板库模板唯一标识
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 操作类型，查询:"SELECT"，删除:"DELETE"，更新:"UPDATE"
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }

        /// <summary>
        /// 操作者的信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 模板可见性, 全部可见-"all", 部分可见-"part"
        /// </summary>
        [JsonProperty("AuthTag")]
        public string AuthTag{ get; set; }

        /// <summary>
        /// 合作企业方第三方机构唯一标识数据，支持多个， 用","进行分隔
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenIds")]
        public string ProxyOrganizationOpenIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "AuthTag", this.AuthTag);
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenIds", this.ProxyOrganizationOpenIds);
        }
    }
}

