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

    public class CreateDocumentRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，userId 必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 签署流程编号,由CreateFlow接口返回
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 用户上传的模板ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 文件名列表，单个文件名最大长度200个字符，暂时仅支持单文件发起
        /// </summary>
        [JsonProperty("FileNames")]
        public string[] FileNames{ get; set; }

        /// <summary>
        /// 内容控件信息数组
        /// </summary>
        [JsonProperty("FormFields")]
        public FormField[] FormFields{ get; set; }

        /// <summary>
        /// 是否需要生成预览文件 默认不生成；
        /// 预览链接有效期300秒；
        /// </summary>
        [JsonProperty("NeedPreview")]
        public bool? NeedPreview{ get; set; }

        /// <summary>
        /// 预览链接类型 默认:0-文件流, 1- H5链接 注意:此参数在NeedPreview 为true 时有效,
        /// </summary>
        [JsonProperty("PreviewType")]
        public long? PreviewType{ get; set; }

        /// <summary>
        /// 应用相关信息
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 客户端Token，保持接口幂等性,最大长度64个字符
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArraySimple(map, prefix + "FileNames.", this.FileNames);
            this.SetParamArrayObj(map, prefix + "FormFields.", this.FormFields);
            this.SetParamSimple(map, prefix + "NeedPreview", this.NeedPreview);
            this.SetParamSimple(map, prefix + "PreviewType", this.PreviewType);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
        }
    }
}

