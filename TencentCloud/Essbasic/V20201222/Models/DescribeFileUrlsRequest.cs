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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFileUrlsRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 业务编号数组，如模板编号、文档编号、印章编号、流程编号、目录编号
        /// </summary>
        [JsonProperty("BusinessIds")]
        public string[] BusinessIds{ get; set; }

        /// <summary>
        /// 业务类型：
        /// 1. TEMPLATE - 模板
        /// 2. SEAL - 印章
        /// 3. FLOW - 流程
        /// 4.CATALOG - 目录
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// 下载后的文件命名，只有FileType为“ZIP”时生效
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 单个业务ID多个资源情况下，指定资源起始偏移量
        /// </summary>
        [JsonProperty("ResourceOffset")]
        public long? ResourceOffset{ get; set; }

        /// <summary>
        /// 单个业务ID多个资源情况下，指定资源数量
        /// </summary>
        [JsonProperty("ResourceLimit")]
        public long? ResourceLimit{ get; set; }

        /// <summary>
        /// 文件类型，支持"JPG", "PDF","ZIP"等，默认为上传的文件类型
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamArraySimple(map, prefix + "BusinessIds.", this.BusinessIds);
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "ResourceOffset", this.ResourceOffset);
            this.SetParamSimple(map, prefix + "ResourceLimit", this.ResourceLimit);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
        }
    }
}

