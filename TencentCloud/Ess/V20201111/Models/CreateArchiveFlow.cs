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

    public class CreateArchiveFlow : AbstractModel
    {
        
        /// <summary>
        /// <p>合同文件的资源id，使用<a href="https://qian.tencent.com/developers/companyApis/templatesAndFiles/UploadFiles" target="_blank">UploadFiles</a> 上传文件返回resourceId，目前一个合同只能支持一个资源ID。</p>
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// <p>合同名称，不传时系统会使用合同资源文件名作为合同名称；最终合同名称不能为空；长度不能超过200，只能由中文、字母、数字和下划线组成。</p>
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// <p>合同类型，自定义文本字符串，长度不能超过200。</p>
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// <p>调用方业务系统中的合同业务编号，可以用于外部系统和归档合同做关联，长度不超过 128 字节</p>
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// <p>合同发起方/创建人名称，用于归档合同展示和检索，长度不超过 32 字符</p>
        /// </summary>
        [JsonProperty("CreatorName")]
        public string CreatorName{ get; set; }

        /// <summary>
        /// <p>签署人信息列表，用于记录合同由哪些个人或企业签署，最多 50 个参与者。</p>
        /// </summary>
        [JsonProperty("ApproverInfo")]
        public ArchiveFlowApproverInfo[] ApproverInfo{ get; set; }

        /// <summary>
        /// <p>关注人信息列表，用于记录合同关注对象，最多 50 个关注者。</p>
        /// </summary>
        [JsonProperty("CcInfo")]
        public ArchiveFlowApproverInfo[] CcInfo{ get; set; }

        /// <summary>
        /// <p>调用方自定义透传数据，可用于保存业务扩展信息，长度不超过 20480 字节。</p>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// <p>合同描述/备注信息，长度不超过 1000 个字符</p>
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// <p>合同签署完成时间，Unix 秒级时间戳</p>
        /// </summary>
        [JsonProperty("ApproveTime")]
        public long? ApproveTime{ get; set; }

        /// <summary>
        /// <p>合同发起时间/合同原始创建时间，Unix 秒级时间戳</p>
        /// </summary>
        [JsonProperty("CustomCreatedOn")]
        public long? CustomCreatedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "CreatorName", this.CreatorName);
            this.SetParamArrayObj(map, prefix + "ApproverInfo.", this.ApproverInfo);
            this.SetParamArrayObj(map, prefix + "CcInfo.", this.CcInfo);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamSimple(map, prefix + "CustomCreatedOn", this.CustomCreatedOn);
        }
    }
}

