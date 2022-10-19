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

    public class Component : AbstractModel
    {
        
        /// <summary>
        /// 控件编号
        /// 
        /// 注：
        /// 当GenerateMode=3时，通过"^"来决定是否使用关键字整词匹配能力。
        /// 例：
        /// 当GenerateMode=3时，如果传入关键字"^甲方签署^"，则会在PDF文件中有且仅有"甲方签署"关键字的地方进行对应操作。
        /// 如传入的关键字为"甲方签署"，则PDF文件中每个出现关键字的位置都会执行相应操作。
        /// 
        /// 创建控件时，此值为空
        /// 查询时返回完整结构
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

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
        /// 控件简称，不能超过30个字符
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// 定义控件是否为必填项，默认为false
        /// </summary>
        [JsonProperty("ComponentRequired")]
        public bool? ComponentRequired{ get; set; }

        /// <summary>
        /// 控件关联的签署方id
        /// </summary>
        [JsonProperty("ComponentRecipientId")]
        public string ComponentRecipientId{ get; set; }

        /// <summary>
        /// 控件所属文件的序号 (文档中文件的排列序号，从0开始)
        /// </summary>
        [JsonProperty("FileIndex")]
        public long? FileIndex{ get; set; }

        /// <summary>
        /// 控件生成的方式：
        /// NORMAL - 普通控件
        /// FIELD - 表单域
        /// KEYWORD - 关键字
        /// </summary>
        [JsonProperty("GenerateMode")]
        public string GenerateMode{ get; set; }

        /// <summary>
        /// 参数控件宽度，默认100，单位px
        /// 表单域和关键字转换控件不用填
        /// </summary>
        [JsonProperty("ComponentWidth")]
        public float? ComponentWidth{ get; set; }

        /// <summary>
        /// 参数控件高度，默认100，单位px
        /// 表单域和关键字转换控件不用填
        /// </summary>
        [JsonProperty("ComponentHeight")]
        public float? ComponentHeight{ get; set; }

        /// <summary>
        /// 参数控件所在页码，从1开始
        /// </summary>
        [JsonProperty("ComponentPage")]
        public long? ComponentPage{ get; set; }

        /// <summary>
        /// 参数控件X位置，单位px
        /// </summary>
        [JsonProperty("ComponentPosX")]
        public float? ComponentPosX{ get; set; }

        /// <summary>
        /// 参数控件Y位置，单位px
        /// </summary>
        [JsonProperty("ComponentPosY")]
        public float? ComponentPosY{ get; set; }

        /// <summary>
        /// 参数控件样式，json格式表述
        /// 不同类型的控件会有部分非通用参数
        /// TEXT控件可以指定字体
        /// 例如：{"FontSize":12}
        /// </summary>
        [JsonProperty("ComponentExtra")]
        public string ComponentExtra{ get; set; }

        /// <summary>
        /// 控件填充vaule，ComponentType和传入值类型对应关系：
        /// TEXT - 文本内容
        /// MULTI_LINE_TEXT - 文本内容
        /// CHECK_BOX - true/false
        /// FILL_IMAGE、ATTACHMENT - 附件的FileId，需要通过UploadFiles接口上传获取
        /// SELECTOR - 选项值
        /// DYNAMIC_TABLE - 传入json格式的表格内容，具体见数据结构FlowInfo：https://cloud.tencent.com/document/api/1420/61525#FlowInfo
        /// </summary>
        [JsonProperty("ComponentValue")]
        public string ComponentValue{ get; set; }

        /// <summary>
        /// 日期签署控件的字号，默认为 12
        /// 
        /// 签署区日期控件会转换成图片格式并带存证，需要通过字体决定图片大小
        /// </summary>
        [JsonProperty("ComponentDateFontSize")]
        public long? ComponentDateFontSize{ get; set; }

        /// <summary>
        /// 控件所属文档的Id, 模块相关接口为空值
        /// </summary>
        [JsonProperty("DocumentId")]
        public string DocumentId{ get; set; }

        /// <summary>
        /// 控件描述，不能超过30个字符
        /// </summary>
        [JsonProperty("ComponentDescription")]
        public string ComponentDescription{ get; set; }

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
            this.SetParamSimple(map, prefix + "ComponentId", this.ComponentId);
            this.SetParamSimple(map, prefix + "ComponentType", this.ComponentType);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ComponentRequired", this.ComponentRequired);
            this.SetParamSimple(map, prefix + "ComponentRecipientId", this.ComponentRecipientId);
            this.SetParamSimple(map, prefix + "FileIndex", this.FileIndex);
            this.SetParamSimple(map, prefix + "GenerateMode", this.GenerateMode);
            this.SetParamSimple(map, prefix + "ComponentWidth", this.ComponentWidth);
            this.SetParamSimple(map, prefix + "ComponentHeight", this.ComponentHeight);
            this.SetParamSimple(map, prefix + "ComponentPage", this.ComponentPage);
            this.SetParamSimple(map, prefix + "ComponentPosX", this.ComponentPosX);
            this.SetParamSimple(map, prefix + "ComponentPosY", this.ComponentPosY);
            this.SetParamSimple(map, prefix + "ComponentExtra", this.ComponentExtra);
            this.SetParamSimple(map, prefix + "ComponentValue", this.ComponentValue);
            this.SetParamSimple(map, prefix + "ComponentDateFontSize", this.ComponentDateFontSize);
            this.SetParamSimple(map, prefix + "DocumentId", this.DocumentId);
            this.SetParamSimple(map, prefix + "ComponentDescription", this.ComponentDescription);
            this.SetParamSimple(map, prefix + "OffsetX", this.OffsetX);
            this.SetParamSimple(map, prefix + "OffsetY", this.OffsetY);
        }
    }
}

