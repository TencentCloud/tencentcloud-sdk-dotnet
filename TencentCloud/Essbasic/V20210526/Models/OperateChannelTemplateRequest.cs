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
        /// 应用相关信息。 
        /// 此接口Agent.AppId必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 操作类型，
        /// 查询:"SELECT"，
        /// 删除:"DELETE"，
        /// 更新:"UPDATE"
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }

        /// <summary>
        /// 第三方应用平台模板库模板唯一标识
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 合作企业方第三方机构唯一标识数据.
        /// 支持多个， 用","进行分隔
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenIds")]
        public string ProxyOrganizationOpenIds{ get; set; }

        /// <summary>
        /// 模板可见性, 
        /// 全部可见-"all",
        ///  部分可见-"part"
        /// </summary>
        [JsonProperty("AuthTag")]
        public string AuthTag{ get; set; }

        /// <summary>
        /// 当OperateType=UPADATE时，可以通过设置此字段对模板启停用状态进行操作。
        /// 若此字段值为0，则不会修改模板Available，
        /// 1为启用模板，
        /// 2为停用模板。
        /// 启用后模板可以正常领取。停用后，推送方式为【自动推送】的模板则无法被子客使用，推送方式为【手动领取】的模板则无法出现被模板库被子客领用。如果Available更新失败，会直接返回错误。
        /// </summary>
        [JsonProperty("Available")]
        public long? Available{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenIds", this.ProxyOrganizationOpenIds);
            this.SetParamSimple(map, prefix + "AuthTag", this.AuthTag);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

