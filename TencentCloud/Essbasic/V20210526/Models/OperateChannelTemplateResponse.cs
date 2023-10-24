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

    public class OperateChannelTemplateResponse : AbstractModel
    {
        
        /// <summary>
        /// 腾讯电子签颁发给第三方应用平台的应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 合同模板ID，为32位字符串。此处为第三方应用平台模板库模板ID，非子客模板ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 描述模板可见性更改的结果，和参数中Available无关。
        /// <ul>
        /// <li>全部成功-"all-success"</li>
        /// <li>部分成功-"part-success"</li>
        /// <li>全部失败-"fail"，失败的会在FailMessageList中展示</li>
        /// </ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateResult")]
        public string OperateResult{ get; set; }

        /// <summary>
        /// 模板可见性, 
        /// <ul>
        /// <li>全部可见-"all"</li>
        /// <li>部分可见-"part"</li>
        /// </ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthTag")]
        public string AuthTag{ get; set; }

        /// <summary>
        /// 第三方平台子客企业的唯一标识，长度不能超过64，只能由字母和数字组成。开发者可自定义此字段的值，并需要保存此 ID 以便进行后续操作。
        /// 
        /// 一个第三方平台子客企业主体与子客企业 ProxyOrganizationOpenId 是一一对应的，不可更改，不可重复使用。例如，可以使用企业名称的哈希值，或者社会统一信用代码的哈希值，或者随机哈希值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenIds")]
        public string[] ProxyOrganizationOpenIds{ get; set; }

        /// <summary>
        /// 操作失败信息数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailMessageList")]
        public AuthFailMessage[] FailMessageList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "OperateResult", this.OperateResult);
            this.SetParamSimple(map, prefix + "AuthTag", this.AuthTag);
            this.SetParamArraySimple(map, prefix + "ProxyOrganizationOpenIds.", this.ProxyOrganizationOpenIds);
            this.SetParamArrayObj(map, prefix + "FailMessageList.", this.FailMessageList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

