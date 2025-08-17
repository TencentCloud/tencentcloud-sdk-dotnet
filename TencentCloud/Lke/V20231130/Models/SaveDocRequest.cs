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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaveDocRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文档支持下面类型
        /// pdf、doc、docx、ppt、mhtml、pptx、wps、ppsx，单个文件不超过200MB；
        /// xlsx、xls、md、txt、csv、html，单个文件不超过20MB；
        /// 
        /// 图片支持下面类型：
        /// jpg、png、jpeg、tiff、bmp、gif，单个文件不超过50MB
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 平台cos路径，与DescribeStorageCredential接口查询UploadPath参数保持一致
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// ETag 全称为 Entity Tag，是对象被创建时标识对象内容的信息标签，可用于检查对象的内容是否发生变化 成功上传cos后，从返回头中获取
        /// </summary>
        [JsonProperty("ETag")]
        public string ETag{ get; set; }

        /// <summary>
        /// cos_hash x-cos-hash-crc64ecma 头部中的 CRC64编码进行校验上传到云端的文件和本地文件的一致性  
        /// 成功上传cos后，从返回头中获取
        /// 
        /// 请注意：
        /// cos_hash为文档唯一性标识，与文件名无关 相同的cos_hash会被判定为重复文档
        /// </summary>
        [JsonProperty("CosHash")]
        public string CosHash{ get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// 标签适用范围，需要传参为1
        /// </summary>
        [JsonProperty("AttrRange")]
        public ulong? AttrRange{ get; set; }

        /// <summary>
        /// 来源（0 从本地文档导入），默认值为0
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 自定义链接地址, IsRefer为true的时候，该值才有意义
        /// </summary>
        [JsonProperty("WebUrl")]
        public string WebUrl{ get; set; }

        /// <summary>
        /// 标签引用
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabelRefer[] AttrLabels{ get; set; }

        /// <summary>
        /// 外部引用链接类型 0：系统链接 1：自定义链接
        /// 值为1时，WebUrl 字段不能为空，否则不生效。
        /// </summary>
        [JsonProperty("ReferUrlType")]
        public ulong? ReferUrlType{ get; set; }

        /// <summary>
        /// 有效开始时间，unix秒级时间戳
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// 有效结束时间，unix秒级时间戳，0代表永久有效
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// 是否引用链接
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// 文档操作类型：1：批量导入（批量导入问答对）；2:文档导入（正常导入单个文档） 默认为1  <br> 请注意，opt=1的时候请从腾讯云智能体开发平台页面下载excel模板
        /// </summary>
        [JsonProperty("Opt")]
        public ulong? Opt{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// 是否可下载，IsRefer为true并且ReferUrlType为0时，该值才有意义
        /// </summary>
        [JsonProperty("IsDownload")]
        public bool? IsDownload{ get; set; }

        /// <summary>
        /// 重复文档处理方式，按顺序匹配第一个满足条件的方式处理
        /// </summary>
        [JsonProperty("DuplicateFileHandles")]
        public DuplicateFileHandle[] DuplicateFileHandles{ get; set; }

        /// <summary>
        /// 自定义切分规则
        /// 
        /// 请求参数为一个 **JSON Object**，具体格式可参见接口示例值。包含以下主要字段：
        /// 
        /// | 字段名             | 类型      | 说明                                   |
        /// |--------------------|--------|----------------------------------------|
        /// | `xlsx_splitter`    | Object   | **Excel（xlsx）文件切分策略配置**，仅当处理 Excel 文件时有效 |
        /// | `common_splitter`  | Object  | **通用文件（如 txt、pdf 等）切分策略配置**，按页或按标签切分 |
        /// | `table_style`      | String | 表格内容的输出格式，如 HTML 或 Markdown |
        /// 
        /// ---
        /// 
        /// ## `xlsx_splitter`（Excel 切分策略）
        /// 
        /// 用于配置 **表格文件的切分方式**。
        /// **类型：Object**
        /// 
        /// ```json
        /// "xlsx_splitter": {
        ///   "header_interval": [1, 2],
        ///   "content_start": 10,
        ///   "split_row": 2
        /// }
        /// ```
        /// 
        /// ### 字段说明：
        /// 
        /// | 字段名            | 类型   | 说明                                                                 |
        /// |-------------------|--------|----------------------------------------------------------------------|
        /// | `header_interval` | Array\<Number\>  | 表头所在的行区间，格式为 `[起始行, 结束行]`，**行号从 1 开始计数**。例如 `[1, 2]` 表示第 1~2 行为表头。 |
        /// | `content_start`   | Number  | **表格内容的起始行号（从 1 开始）**。 |
        /// | `split_row`       | Number   | **切分行数**。                   |
        /// 
        /// ---
        /// ## `common_splitter`（通用文件切分策略）
        /// 
        /// 用于配置 **非 Excel 文件（如 TXT、PDF、DOCX 等）的切分方式**，支持两种策略：**按页切分（page）** 或 **按标识符切分（tag）**。
        /// 
        /// **类型：Object**
        /// 
        /// ```json
        /// "common_splitter": {
        ///   "splitter": "page",
        ///   "page_splitter": {
        ///     "chunk_length": 1000,
        ///     "chunk_overlap_length": 100
        ///   }
        /// }
        /// ```
        /// 
        /// ### 字段说明：
        /// 
        /// | 字段名            | 类型     | 说明                                                                 |
        /// |-------------------|--------|---------------------------------------------------|
        /// | `splitter`        | String  | 切分策略类型，可选值为：`"page"`（按页切分） 或 `"tag"`（按标识符切分）。 |
        /// | `page_splitter`   | Object   | **按页切分的配置**。                                         |
        /// | `page_splitter.chunk_length`   | 1000    | **切片最大长度**。              |
        /// | `page_splitter.chunk_overlap_length`  | 100    | **切片重叠长度**。  |
        /// | `tag_splitter`             | Object          | **自定义切分配置**。             |
        /// | `tag_splitter.tag`         | Array\<String\>    | **切分标识符**。                             |
        /// | `tag_splitter.chunk_length`| Number       | **切片最大长度**。                                                               |
        /// | `tag_splitter.chunk_overlap_length` | Number    | **切块重叠长度**。                                                  |
        /// 
        /// 🔹 **补充说明：**
        /// 
        /// - `splitter` 字段的值可以是：
        ///   - `"page"`：只使用按页切分逻辑，此时只需要关心 `page_splitter` 相关字段。
        ///   - `"tag"`：只使用按标识符（如分号、换行等）切分逻辑，此时关注 `tag_splitter`。
        /// ---
        /// 
        /// ##  `table_style`（表格输出样式）
        /// 
        /// 用于指定 **表格类内容（比如从 Excel 或 CSV 中提取的表格）最终以何种格式返回**，方便前端展示或后续处理。
        /// 
        /// **类型：String**
        /// 
        /// ```json
        /// "table_style": "md"
        /// ```
        /// 
        /// ### 字段说明：
        /// 
        /// | 字段名       | 类型   | 说明                                                                 |
        /// |--------------|--------|----------------------------------------------------------------------|
        /// | `table_style` | String | 指定表格内容的输出格式。可用值：<br>• `"html"`：以 HTML 表格形式返回，适合网页展示。<br>• `"md"`：以 Markdown 表格语法返回，适合文档或 Markdown 渲染环境。|
        /// </summary>
        [JsonProperty("SplitRule")]
        public string SplitRule{ get; set; }

        /// <summary>
        /// 文档更新频率
        /// </summary>
        [JsonProperty("UpdatePeriodInfo")]
        public UpdatePeriodInfo UpdatePeriodInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "ETag", this.ETag);
            this.SetParamSimple(map, prefix + "CosHash", this.CosHash);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "WebUrl", this.WebUrl);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "ReferUrlType", this.ReferUrlType);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamSimple(map, prefix + "IsRefer", this.IsRefer);
            this.SetParamSimple(map, prefix + "Opt", this.Opt);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "IsDownload", this.IsDownload);
            this.SetParamArrayObj(map, prefix + "DuplicateFileHandles.", this.DuplicateFileHandles);
            this.SetParamSimple(map, prefix + "SplitRule", this.SplitRule);
            this.SetParamObj(map, prefix + "UpdatePeriodInfo.", this.UpdatePeriodInfo);
        }
    }
}

