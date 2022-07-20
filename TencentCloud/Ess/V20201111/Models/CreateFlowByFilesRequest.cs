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

    public class CreateFlowByFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 签署流程名称,最大长度200个字符
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 签署参与者信息
        /// </summary>
        [JsonProperty("Approvers")]
        public ApproverInfo[] Approvers{ get; set; }

        /// <summary>
        /// 签署pdf文件的资源编号列表，通过UploadFiles接口获取
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 调用方用户信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 应用号信息
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 经办人内容控件配置。可选类型为：
        /// TEXT - 内容文本控件
        /// MULTI_LINE_TEXT - 多行文本控件
        /// CHECK_BOX - 勾选框控件
        /// ATTACHMENT - 附件
        /// 注：默认字体大小为 字号12
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

        /// <summary>
        /// 签署流程的签署截止时间。
        /// 值为unix时间戳,精确到秒,不传默认为当前时间一年后
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 发送类型：
        /// true：无序签
        /// false：有序签
        /// 注：默认为false（有序签）
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 是否需要预览，true：预览模式，false：非预览（默认）；
        /// 预览链接有效期300秒；
        /// </summary>
        [JsonProperty("NeedPreview")]
        public bool? NeedPreview{ get; set; }

        /// <summary>
        /// 签署流程描述,最大长度1000个字符
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 签署流程的类型(如销售合同/入职合同等)，最大长度200个字符
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 被抄送人的信息列表。
        /// 注:此功能为白名单功能，若有需要，请联系电子签客服开白使用
        /// </summary>
        [JsonProperty("CcInfos")]
        public CcInfo[] CcInfos{ get; set; }

        /// <summary>
        /// 合同显示的页卡模板，说明：只支持{合同名称}, {发起方企业}, {发起方姓名}, {签署方N企业}, {签署方N姓名}，且N不能超过签署人的数量，N从1开始
        /// </summary>
        [JsonProperty("CustomShowMap")]
        public string CustomShowMap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "NeedPreview", this.NeedPreview);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamArrayObj(map, prefix + "CcInfos.", this.CcInfos);
            this.SetParamSimple(map, prefix + "CustomShowMap", this.CustomShowMap);
        }
    }
}

