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

    public class Component : AbstractModel
    {
        
        /// <summary>
        /// 如果是Component控件类型，则可选的字段为：
        /// TEXT - 普通文本控件；
        /// MULTI_LINE_TEXT - 多行文本控件；
        /// CHECK_BOX - 勾选框控件；
        /// FILL_IMAGE - 图片控件；
        /// DYNAMIC_TABLE - 动态表格控件；
        /// ATTACHMENT - 附件控件；
        /// SELECTOR - 选择器控件；
        /// 
        /// 如果是SignComponent控件类型，则可选的字段为
        /// SIGN_SEAL - 签署印章控件；
        /// SIGN_DATE - 签署日期控件；
        /// SIGN_SIGNATURE - 用户签名控件；
        /// SIGN_PERSONAL_SEAL - 个人签署印章控件（使用文件发起暂不支持此类型）；
        /// 
        /// 表单域的控件不能作为印章和签名控件
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// 参数控件宽度，单位pt
        /// </summary>
        [JsonProperty("ComponentWidth")]
        public float? ComponentWidth{ get; set; }

        /// <summary>
        /// 参数控件高度，单位pt
        /// </summary>
        [JsonProperty("ComponentHeight")]
        public float? ComponentHeight{ get; set; }

        /// <summary>
        /// 参数控件所在页码，取值为：1-N
        /// </summary>
        [JsonProperty("ComponentPage")]
        public long? ComponentPage{ get; set; }

        /// <summary>
        /// 参数控件X位置，单位pt
        /// </summary>
        [JsonProperty("ComponentPosX")]
        public float? ComponentPosX{ get; set; }

        /// <summary>
        /// 参数控件Y位置，单位pt
        /// </summary>
        [JsonProperty("ComponentPosY")]
        public float? ComponentPosY{ get; set; }

        /// <summary>
        /// 控件所属文件的序号（模板中的resourceId排列序号，取值为：0-N）
        /// </summary>
        [JsonProperty("FileIndex")]
        public long? FileIndex{ get; set; }

        /// <summary>
        /// GenerateMode==KEYWORD 指定关键字
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

        /// <summary>
        /// GenerateMode==FIELD 指定表单域名称
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// 是否必选，默认为false
        /// </summary>
        [JsonProperty("ComponentRequired")]
        public bool? ComponentRequired{ get; set; }

        /// <summary>
        /// 扩展参数：
        /// ComponentType为SIGN_SIGNATURE类型可以控制签署方式
        /// {“ComponentTypeLimit”: [“xxx”]}
        /// xxx可以为：
        /// HANDWRITE – 手写签名
        /// BORDERLESS_ESIGN – 自动生成无边框腾讯体
        /// OCR_ESIGN -- AI智能识别手写签名
        /// ESIGN -- 个人印章类型
        /// 如：{“ComponentTypeLimit”: [“BORDERLESS_ESIGN”]}
        /// </summary>
        [JsonProperty("ComponentExtra")]
        public string ComponentExtra{ get; set; }

        /// <summary>
        /// 控件关联的签署人ID
        /// </summary>
        [JsonProperty("ComponentRecipientId")]
        public string ComponentRecipientId{ get; set; }

        /// <summary>
        /// 控件填充vaule，ComponentType和传入值类型对应关系：
        /// TEXT - 文本内容
        /// MULTI_LINE_TEXT - 文本内容
        /// CHECK_BOX - true/false
        /// FILL_IMAGE、ATTACHMENT - 附件的FileId，需要通过UploadFiles接口上传获取
        /// SELECTOR - 选项值
        /// DYNAMIC_TABLE - 传入json格式的表格内容，具体见数据结构FlowInfo：https://cloud.tencent.com/document/api/1420/61525#FlowInfo
        /// SIGN_SEAL - 印章Id，于控制台查询获取
        /// </summary>
        [JsonProperty("ComponentValue")]
        public string ComponentValue{ get; set; }

        /// <summary>
        /// 是否是表单域类型，默认不存在
        /// </summary>
        [JsonProperty("IsFormType")]
        public bool? IsFormType{ get; set; }

        /// <summary>
        /// NORMAL 正常模式，使用坐标制定签署控件位置
        /// FIELD 表单域，需使用ComponentName指定表单域名称
        /// KEYWORD 关键字，使用ComponentId指定关键字
        /// </summary>
        [JsonProperty("GenerateMode")]
        public string GenerateMode{ get; set; }

        /// <summary>
        /// 日期控件类型字号
        /// </summary>
        [JsonProperty("ComponentDateFontSize")]
        public long? ComponentDateFontSize{ get; set; }

        /// <summary>
        /// 指定关键字时横坐标偏移量，单位pt
        /// </summary>
        [JsonProperty("OffsetX")]
        public float? OffsetX{ get; set; }

        /// <summary>
        /// 指定关键字时纵坐标偏移量，单位pt
        /// </summary>
        [JsonProperty("OffsetY")]
        public float? OffsetY{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentType", this.ComponentType);
            this.SetParamSimple(map, prefix + "ComponentWidth", this.ComponentWidth);
            this.SetParamSimple(map, prefix + "ComponentHeight", this.ComponentHeight);
            this.SetParamSimple(map, prefix + "ComponentPage", this.ComponentPage);
            this.SetParamSimple(map, prefix + "ComponentPosX", this.ComponentPosX);
            this.SetParamSimple(map, prefix + "ComponentPosY", this.ComponentPosY);
            this.SetParamSimple(map, prefix + "FileIndex", this.FileIndex);
            this.SetParamSimple(map, prefix + "ComponentId", this.ComponentId);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ComponentRequired", this.ComponentRequired);
            this.SetParamSimple(map, prefix + "ComponentExtra", this.ComponentExtra);
            this.SetParamSimple(map, prefix + "ComponentRecipientId", this.ComponentRecipientId);
            this.SetParamSimple(map, prefix + "ComponentValue", this.ComponentValue);
            this.SetParamSimple(map, prefix + "IsFormType", this.IsFormType);
            this.SetParamSimple(map, prefix + "GenerateMode", this.GenerateMode);
            this.SetParamSimple(map, prefix + "ComponentDateFontSize", this.ComponentDateFontSize);
            this.SetParamSimple(map, prefix + "OffsetX", this.OffsetX);
            this.SetParamSimple(map, prefix + "OffsetY", this.OffsetY);
        }
    }
}

