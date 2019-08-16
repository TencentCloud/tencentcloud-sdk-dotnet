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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitTraditionalClassTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入分析对象内容，仅支持url，暂不支持直接上传base64图片
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 输入分析对象类型，picture_url:图片地址，vod_url:视频地址，live_url：直播地址
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 查询人员库列表，可填写学生们的注册照所在人员库
        /// </summary>
        [JsonProperty("LibrarySet")]
        public string[] LibrarySet{ get; set; }

        /// <summary>
        /// 直播流评估时间，在FileType为live_url时生效，默认值为10分钟。
        /// </summary>
        [JsonProperty("MaxVideoDuration")]
        public long? MaxVideoDuration{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamArraySimple(map, prefix + "LibrarySet.", this.LibrarySet);
            this.SetParamSimple(map, prefix + "MaxVideoDuration", this.MaxVideoDuration);
        }
    }
}

