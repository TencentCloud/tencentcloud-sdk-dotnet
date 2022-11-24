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
        /// DATE - 日期控件；默认是格式化为xxxx年xx月xx日；
        /// DISTRICT - 省市区行政区划控件；
        /// 
        /// 如果是SignComponent控件类型，则可选的字段为
        /// SIGN_SEAL - 签署印章控件；
        /// SIGN_DATE - 签署日期控件；
        /// DATE， 日期控件，默认是格式化为xxxx年xx月xx日
        /// SIGN_SIGNATURE - 用户签名控件；
        /// SIGN_PERSONAL_SEAL - 个人签署印章控件（使用文件发起暂不支持此类型）；
        /// SIGN_PAGING_SEAL - 骑缝章；若文件发起，需要对应填充ComponentPosY、ComponentWidth、ComponentHeight
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
        /// 为JSON格式。
        /// 
        /// ComponentType为FILL_IMAGE时，支持以下参数：
        /// NotMakeImageCenter：bool。是否设置图片居中。false：居中（默认）。 true: 不居中
        /// FillMethod: int. 填充方式。0-铺满（默认）；1-等比例缩放
        /// 
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
        /// DATE - 默认是格式化为xxxx年xx月xx日
        /// SIGN_SEAL - 印章ID，于控制台查询获取
        /// SIGN_PAGING_SEAL - 可以指定印章ID，于控制台查询获取
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
        /// 指定关键字排序规则，Positive-正序，Reverse-倒序。传入Positive时会根据关键字在PDF文件内的顺序进行排列。在指定KeywordIndexes时，0代表在PDF内查找内容时，查找到的第一个关键字。
        /// 传入Reverse时会根据关键字在PDF文件内的反序进行排列。在指定KeywordIndexes时，0代表在PDF内查找内容时，查找到的最后一个关键字。
        /// </summary>
        [JsonProperty("KeywordOrder")]
        public string KeywordOrder{ get; set; }

        /// <summary>
        /// 指定关键字页码，可选参数，指定页码后，将只在指定的页码内查找关键字，非该页码的关键字将不会查询出来
        /// </summary>
        [JsonProperty("KeywordPage")]
        public long? KeywordPage{ get; set; }

        /// <summary>
        /// 关键字位置模式，Middle-居中，Below-正下方，Right-正右方，LowerRight-右上角，UpperRight-右下角。示例：如果设置Middle的关键字盖章，则印章的中心会和关键字的中心重合，如果设置Below，则印章在关键字的正下方
        /// </summary>
        [JsonProperty("RelativeLocation")]
        public string RelativeLocation{ get; set; }

        /// <summary>
        /// 关键字索引，可选参数，如果一个关键字在PDF文件中存在多个，可以通过关键字索引指定使用第几个关键字作为最后的结果，可指定多个索引。示例：[0,2]，说明使用PDF文件内第1个和第3个关键字位置。
        /// </summary>
        [JsonProperty("KeywordIndexes")]
        public long?[] KeywordIndexes{ get; set; }


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
            this.SetParamSimple(map, prefix + "KeywordOrder", this.KeywordOrder);
            this.SetParamSimple(map, prefix + "KeywordPage", this.KeywordPage);
            this.SetParamSimple(map, prefix + "RelativeLocation", this.RelativeLocation);
            this.SetParamArraySimple(map, prefix + "KeywordIndexes.", this.KeywordIndexes);
        }
    }
}

