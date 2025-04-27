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
        /// 文件类型(md|txt|docx|pdf|xlsx)
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
        /// 来源(0 源文件导入 1 网页导入)
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 网页(或自定义链接)地址
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
        /// 有效开始时间，unix时间戳
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// 有效结束时间，unix时间戳，0代表永久有效
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// 是否引用链接
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// 文档操作类型：1：批量导入（批量导入问答对）；2:文档导入（正常导入单个文档） 默认为1  <br> 请注意，opt=1的时候请从知识引擎页面下载excel模板
        /// </summary>
        [JsonProperty("Opt")]
        public ulong? Opt{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }


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
        }
    }
}

