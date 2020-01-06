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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTranscodeResponse : AbstractModel
    {
        
        /// <summary>
        /// 文档的总页数
        /// </summary>
        [JsonProperty("Pages")]
        public long? Pages{ get; set; }

        /// <summary>
        /// 转码的当前进度,取值范围为0~100
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 文档的分辨率
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 转码完成后结果的URL
        /// 动态转码：PPT转动态H5的链接
        /// 静态转码：文档每一页的图片URL前缀，比如，该URL前缀为`http://example.com/g0jb42ps49vtebjshilb/`，那么文档第1页的图片URL为
        /// `http://example.com/g0jb42ps49vtebjshilb/1.jpg`，其它页以此类推
        /// </summary>
        [JsonProperty("ResultUrl")]
        public string ResultUrl{ get; set; }

        /// <summary>
        /// 任务的当前状态
        /// - QUEUED: 正在排队等待转换
        /// - PROCESSING: 转换中
        /// - FINISHED: 转换完成
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 转码任务的唯一标识Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 文档的文件名
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 缩略图URL前缀，比如，该URL前缀为`http://example.com/g0jb42ps49vtebjshilb/ `，那么动态PPT第1页的缩略图URL为
        /// `http://example.com/g0jb42ps49vtebjshilb/1.jpg`，其它页以此类推
        /// 
        /// 如果发起文档转码请求参数中带了ThumbnailResolution参数，并且转码类型为动态转码，该参数不为空，其余情况该参数为空字符串
        /// </summary>
        [JsonProperty("ThumbnailUrl")]
        public string ThumbnailUrl{ get; set; }

        /// <summary>
        /// 动态转码缩略图生成分辨率
        /// </summary>
        [JsonProperty("ThumbnailResolution")]
        public string ThumbnailResolution{ get; set; }

        /// <summary>
        /// 转码压缩文件下载的URL，如果发起文档转码请求参数中`CompressFileType`为空或者不是支持的压缩格式，该参数为空字符串
        /// </summary>
        [JsonProperty("CompressFileUrl")]
        public string CompressFileUrl{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pages", this.Pages);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "ResultUrl", this.ResultUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "ThumbnailUrl", this.ThumbnailUrl);
            this.SetParamSimple(map, prefix + "ThumbnailResolution", this.ThumbnailResolution);
            this.SetParamSimple(map, prefix + "CompressFileUrl", this.CompressFileUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

