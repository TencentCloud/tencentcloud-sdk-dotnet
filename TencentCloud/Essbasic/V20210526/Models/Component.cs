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
        /// CreateFlowByTemplates发起合同时优先以ComponentId（不为空）填充；否则以ComponentName填充
        /// 
        /// 注：
        /// 当GenerateMode=KEYWORD时，通过"^"来决定是否使用关键字整词匹配能力。
        /// 例：当GenerateMode=KEYWORD时，如果传入关键字"^甲方签署^"，则会在PDF文件中有且仅有"甲方签署"关键字的地方进行对应操作。
        /// 如传入的关键字为"甲方签署"，则PDF文件中每个出现关键字的位置都会执行相应操作。
        /// 
        /// 创建控件时，此值为空
        /// 查询时返回完整结构
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

        /// <summary>
        /// 如果是Component控件类型，则可选的字段为：
        /// TEXT - 普通文本控件，输入文本字符串；
        /// MULTI_LINE_TEXT - 多行文本控件，输入文本字符串；
        /// CHECK_BOX - 勾选框控件，若选中填写ComponentValue 填写 true或者 false 字符串；
        /// FILL_IMAGE - 图片控件，ComponentValue 填写图片的资源 ID；
        /// DYNAMIC_TABLE - 动态表格控件；
        /// ATTACHMENT - 附件控件,ComponentValue 填写附件图片的资源 ID列表，以逗号分割；
        /// SELECTOR - 选择器控件，ComponentValue填写选择的字符串内容；
        /// DATE - 日期控件；默认是格式化为xxxx年xx月xx日字符串；
        /// DISTRICT - 省市区行政区控件，ComponentValue填写省市区行政区字符串内容；
        /// 
        /// 如果是SignComponent控件类型，则可选的字段为
        /// SIGN_SEAL - 签署印章控件；
        /// SIGN_DATE - 签署日期控件；
        /// SIGN_SIGNATURE - 用户签名控件；
        /// SIGN_PERSONAL_SEAL - 个人签署印章控件（使用文件发起暂不支持此类型）；
        /// SIGN_PAGING_SEAL - 骑缝章；若文件发起，需要对应填充ComponentPosY、ComponentWidth、ComponentHeight
        /// SIGN_OPINION - 签署意见控件，用户需要根据配置的签署意见内容，完成对意见内容的确认;
        /// SIGN_LEGAL_PERSON_SEAL - 企业法定代表人控件。
        /// 
        /// 表单域的控件不能作为印章和签名控件
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// 控件简称，不超过30个字符
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// 控件是否为必填项，
        /// 默认为false-非必填
        /// </summary>
        [JsonProperty("ComponentRequired")]
        public bool? ComponentRequired{ get; set; }

        /// <summary>
        /// 控件关联的参与方ID，对应Recipient结构体中的RecipientId	
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
        /// 扩展参数：
        /// 为JSON格式。
        /// 不同类型的控件会有部分非通用参数
        /// 
        /// TEXT/MULTI_LINE_TEXT控件可以指定
        /// 1 Font：目前只支持黑体、宋体
        /// 2 FontSize： 范围12-72
        /// 3 FontAlign： Left/Right/Center，左对齐/居中/右对齐
        /// 例如：{"FontSize":12}
        /// 
        /// ComponentType为FILL_IMAGE时，支持以下参数：
        /// NotMakeImageCenter：bool。是否设置图片居中。false：居中（默认）。 true: 不居中
        /// FillMethod: int. 填充方式。0-铺满（默认）；1-等比例缩放
        /// 
        /// ComponentType为SIGN_SIGNATURE类型可以控制签署方式
        /// {“ComponentTypeLimit”: [“xxx”]}
        /// xxx可以为：
        /// HANDWRITE – 手写签名
        /// OCR_ESIGN -- AI智能识别手写签名
        /// ESIGN -- 个人印章类型
        /// SYSTEM_ESIGN -- 系统签名（该类型可以在用户签署时根据用户姓名一键生成一个签名来进行签署）
        /// 如：{“ComponentTypeLimit”: [“SYSTEM_ESIGN”]}
        /// 
        /// ComponentType为SIGN_DATE时，支持以下参数：
        /// 1 Font：字符串类型目前只支持"黑体"、"宋体"，如果不填默认为"黑体"
        /// 2 FontSize： 数字类型，范围6-72，默认值为12
        /// 3 FontAlign： 字符串类型，可取Left/Right/Center，对应左对齐/居中/右对齐
        /// 4 Format： 字符串类型，日期格式，必须是以下五种之一 “yyyy m d”，”yyyy年m月d日”，”yyyy/m/d”，”yyyy-m-d”，”yyyy.m.d”。
        /// 5 Gaps:： 字符串类型，仅在Format为“yyyy m d”时起作用，格式为用逗号分开的两个整数，例如”2,2”，两个数字分别是日期格式的前后两个空隙中的空格个数
        /// 如果extra参数为空，默认为”yyyy年m月d日”格式的居中日期
        /// 特别地，如果extra中Format字段为空或无法被识别，则extra参数会被当作默认值处理（Font，FontSize，Gaps和FontAlign都不会起效）
        /// 参数样例： "ComponentExtra": "{"Format":“yyyy m d”,"FontSize":12,"Gaps":"2,2", "FontAlign":"Right"}"
        /// 
        /// ComponentType为SIGN_SEAL类型时，支持以下参数：
        /// 1.PageRanges：PageRange的数组，通过PageRanges属性设置该印章在PDF所有页面上盖章（适用于标书在所有页面盖章的情况）
        /// 参数样例： "ComponentExtra":"{["PageRange":{"BeginPage":1,"EndPage":-1}]}"
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
        /// DATE - 默认是格式化为xxxx年xx月xx日
        /// DYNAMIC_TABLE - 传入json格式的表格内容，具体见数据结构FlowInfo：https://cloud.tencent.com/document/api/1420/61525#FlowInfo
        /// SIGN_SEAL - 印章ID
        /// SIGN_PAGING_SEAL - 可以指定印章ID
        /// 
        /// 控件值约束说明：
        /// 企业全称控件：
        ///   约束：企业名称中文字符中文括号
        ///   检查正则表达式：/^[\u3400-\u4dbf\u4e00-\u9fa5（）]+$/
        /// 
        /// 统一社会信用代码控件：
        ///   检查正则表达式：/^[A-Z0-9]{1,18}$/
        /// 
        /// 法人名称控件：
        ///   约束：最大50个字符，2到25个汉字或者1到50个字母
        ///   检查正则表达式：/^([\u3400-\u4dbf\u4e00-\u9fa5.·]{2,25}|[a-zA-Z·,\s-]{1,50})$/
        /// 
        /// 签署意见控件：
        ///   约束：签署意见最大长度为50字符
        /// 
        /// 签署人手机号控件：
        ///   约束：国内手机号 13,14,15,16,17,18,19号段长度11位
        /// 
        /// 签署人身份证控件：
        ///   约束：合法的身份证号码检查
        /// 
        /// 控件名称：
        ///   约束：控件名称最大长度为20字符
        /// 
        /// 单行文本控件：
        ///   约束：只允许输入中文，英文，数字，中英文标点符号
        /// 
        /// 多行文本控件：
        ///   约束：只允许输入中文，英文，数字，中英文标点符号
        /// 
        /// 勾选框控件：
        ///   约束：选择填字符串true，不选填字符串false
        /// 
        /// 选择器控件：
        ///   约束：同单行文本控件约束，填写选择值中的字符串
        /// 
        /// 数字控件：
        ///   约束：请输入有效的数字(可带小数点) 
        ///   检查正则表达式：/^(-|\+)?\d+(\.\d+)?$/
        /// 
        /// 日期控件：
        ///   约束：格式：yyyy年mm月dd日
        /// 
        /// 附件控件：
        ///   约束：JPG或PNG图片，上传数量限制，1到6个，最大6个附件
        /// 
        /// 图片控件：
        ///   约束：JPG或PNG图片，填写上传的图片资源ID
        /// 
        /// 邮箱控件：
        ///   约束：请输入有效的邮箱地址, w3c标准
        ///   检查正则表达式：/^([A-Za-z0-9_\-.!#$%&])+@([A-Za-z0-9_\-.])+\.([A-Za-z]{2,4})$/
        ///   参考：https://emailregex.com/
        /// 
        /// 地址控件：
        ///   同单行文本控件约束
        /// 
        /// 省市区控件：
        ///   同单行文本控件约束
        /// 
        /// 性别控件：
        ///   同单行文本控件约束，填写选择值中的字符串
        /// 
        /// 学历控件：
        ///   同单行文本控件约束，填写选择值中的字符串
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
        /// 控件所属文档的Id, 模板相关接口为空值
        /// </summary>
        [JsonProperty("DocumentId")]
        public string DocumentId{ get; set; }

        /// <summary>
        /// 控件描述，不超过30个字符
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
        /// 平台企业控件ID。
        /// 如果不为空，属于平台企业预设控件；
        /// </summary>
        [JsonProperty("ChannelComponentId")]
        public string ChannelComponentId{ get; set; }

        /// <summary>
        /// 指定关键字排序规则，
        /// Positive-正序，
        /// Reverse-倒序。
        /// 传入Positive时会根据关键字在PDF文件内的顺序进行排列。在指定KeywordIndexes时，0代表在PDF内查找内容时，查找到的第一个关键字。
        /// 传入Reverse时会根据关键字在PDF文件内的反序进行排列。在指定KeywordIndexes时，0代表在PDF内查找内容时，查找到的最后一个关键字。
        /// </summary>
        [JsonProperty("KeywordOrder")]
        public string KeywordOrder{ get; set; }

        /// <summary>
        /// 指定关键字页码。
        /// 指定页码后，将只在指定的页码内查找关键字，非该页码的关键字将不会查询出来
        /// </summary>
        [JsonProperty("KeywordPage")]
        public long? KeywordPage{ get; set; }

        /// <summary>
        /// 关键字位置模式，
        /// Middle-居中，
        /// Below-正下方，
        /// Right-正右方，
        /// LowerRight-右上角，
        /// UpperRight-右下角。
        /// 示例：如果设置Middle的关键字盖章，则印章的中心会和关键字的中心重合，如果设置Below，则印章在关键字的正下方
        /// </summary>
        [JsonProperty("RelativeLocation")]
        public string RelativeLocation{ get; set; }

        /// <summary>
        /// 关键字索引，如果一个关键字在PDF文件中存在多个，可以通过关键字索引指定使用第几个关键字作为最后的结果，可指定多个索引。
        /// 示例[0,2]，说明使用PDF文件内第1个和第3个关键字位置。
        /// </summary>
        [JsonProperty("KeywordIndexes")]
        public long?[] KeywordIndexes{ get; set; }

        /// <summary>
        /// 填写提示的内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Placeholder")]
        public string Placeholder{ get; set; }


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
            this.SetParamSimple(map, prefix + "ChannelComponentId", this.ChannelComponentId);
            this.SetParamSimple(map, prefix + "KeywordOrder", this.KeywordOrder);
            this.SetParamSimple(map, prefix + "KeywordPage", this.KeywordPage);
            this.SetParamSimple(map, prefix + "RelativeLocation", this.RelativeLocation);
            this.SetParamArraySimple(map, prefix + "KeywordIndexes.", this.KeywordIndexes);
            this.SetParamSimple(map, prefix + "Placeholder", this.Placeholder);
        }
    }
}

