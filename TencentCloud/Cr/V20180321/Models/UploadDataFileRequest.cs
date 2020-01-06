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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadDataFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，本接口取值：Data
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名，本接口取值：Upload
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>上传类型，不填默认到期/逾期提醒文件，取值范围：</p><ul style="margin-bottom:0px;"><li>data：到期/逾期提醒文件</li><li>repay：到期/逾期提醒停拨文件</li><li>callback：回访文件</li><li>callstop：回访停拨文件</li></ul>
        /// </summary>
        [JsonProperty("UploadModel")]
        public string UploadModel{ get; set; }

        /// <summary>
        /// 文件，文件与文件地址上传只可选用一种，必须使用multipart/form-data协议来上传二进制流文件，建议使用xlsx格式，大小不超过5MB。
        /// </summary>
        [JsonProperty("File")]
        public string File{ get; set; }

        /// <summary>
        /// 文件上传地址，文件与文件地址上传只可选用一种，大小不超过50MB。
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 实例ID，不传默认为系统分配的初始实例。
        /// </summary>
        [JsonProperty("InstId")]
        public string InstId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "UploadModel", this.UploadModel);
            this.SetParamSimple(map, prefix + "File", this.File);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "InstId", this.InstId);
        }
    }
}

