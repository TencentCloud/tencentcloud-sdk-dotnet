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

    public class CreateReconstructDocumentFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件类型。支持的文件类型：PDF、DOC、DOCX、PPT、PPTX、MD、TXT、XLS、XLSX、CSV、PNG、JPG、JPEG、BMP、GIF、WEBP、HEIC、EPS、ICNS、IM、PCX、PPM、TIFF、XBM、HEIF、JP2。
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 文件的 Base64 值。支持的文件大小：所下载文件经Base64编码后不超过 8M。文件下载时间不超过 3 秒。支持的图片像素：单边介于20-10000px之间。文件的 FileUrl、FileBase64 必须提供一个，如果都提供，只使用 FileUrl。
        /// </summary>
        [JsonProperty("FileBase64")]
        public string FileBase64{ get; set; }

        /// <summary>
        /// <p>文件的Url地址。文件下载时间不超过15秒。支持的图片像素：单边介于20-10000px之间。文件存储于腾讯云的Url可保障更高的下载速度和稳定性，建议文件存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。所下载文件经 Base64 编码后不超过支持的文件大小：</p><table>  <tbody>    <tr>      <td>文件类型</td>      <td>支持的文件大小</td>    </tr>    <tr>      <td>PDF</td>      <td>200M</td>    </tr>    <tr>      <td>DOC</td>      <td>200M</td>    </tr>    <tr>      <td>DOCX</td>      <td>200M</td>    </tr>    <tr>      <td>PPT</td>      <td>200M</td>    </tr>    <tr>      <td>PPTX</td>      <td>200M</td>    </tr>    <tr>      <td>MD</td>      <td>10M</td>    </tr>    <tr>      <td>TXT</td>      <td>10M</td>    </tr>    <tr>      <td>XLS</td>      <td>20M</td>    </tr>    <tr>      <td>XLSX</td>      <td>20M</td>    </tr>    <tr>      <td>CSV</td>      <td>20M</td>    </tr>    <tr>      <td>PNG</td>      <td>20M</td>    </tr>    <tr>      <td>JPG</td>      <td>20M</td>    </tr>    <tr>      <td>JPEG</td>      <td>20M</td>    </tr>    <tr>      <td>BMP</td>      <td>20M</td>    </tr>    <tr>      <td>GIF</td>      <td>20M</td>    </tr>    <tr>      <td>WEBP</td>      <td>20M</td>    </tr>    <tr>      <td>HEIC</td>      <td>20M</td>    </tr>    <tr>      <td>EPS</td>      <td>20M</td>    </tr>    <tr>      <td>ICNS</td>      <td>20M</td>    </tr>    <tr>      <td>IM</td>      <td>20M</td>    </tr>    <tr>      <td>PCX</td>      <td>20M</td>    </tr>    <tr>      <td>PPM</td>      <td>20M</td>    </tr>    <tr>      <td>TIFF</td>      <td>20M</td>    </tr>    <tr>      <td>XBM</td>      <td>20M</td>    </tr>    <tr>      <td>HEIF</td>      <td>20M</td>    </tr>    <tr>      <td>JP2</td>      <td>20M</td>    </tr>  </tbody>  <colgroup>    <col>    <col>  </colgroup></table>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 当传入文件类型为PDF、DOC、DOCX、PPT、PPTX，用来指定文件识别的起始页码，识别的页码包含当前值。默认为1，表示从文件的第1页开始识别。
        /// </summary>
        [JsonProperty("FileStartPageNumber")]
        public long? FileStartPageNumber{ get; set; }

        /// <summary>
        /// 当传入文件类型为PDF、DOC、DOCX、PPT、PPTX，用来指定文件识别的结束页码，识别的页码包含当前值。默认为100，表示识别到文件的第100页。单次调用最多支持识别1000页内容，即FileEndPageNumber-FileStartPageNumber需要不大于1000。
        /// </summary>
        [JsonProperty("FileEndPageNumber")]
        public long? FileEndPageNumber{ get; set; }

        /// <summary>
        /// 创建文档解析任务配置信息。
        /// </summary>
        [JsonProperty("Config")]
        public CreateReconstructDocumentFlowConfig Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileBase64", this.FileBase64);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileStartPageNumber", this.FileStartPageNumber);
            this.SetParamSimple(map, prefix + "FileEndPageNumber", this.FileEndPageNumber);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

