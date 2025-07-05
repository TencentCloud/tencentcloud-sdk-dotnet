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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdgePackTaskStatus : AbstractModel
    {
        
        /// <summary>
        /// APK 名称
        /// </summary>
        [JsonProperty("Apk")]
        public string Apk{ get; set; }

        /// <summary>
        /// 输出目录
        /// </summary>
        [JsonProperty("DstDir")]
        public string DstDir{ get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        [JsonProperty("UploadTime")]
        public string UploadTime{ get; set; }

        /// <summary>
        /// 任务状态
        /// created: 创建成功
        /// processing: 处理中
        /// done: 处理完成
        /// failed: 处理失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 上传目录
        /// </summary>
        [JsonProperty("SrcDir")]
        public string[] SrcDir{ get; set; }

        /// <summary>
        /// 失败任务状态详情
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Apk", this.Apk);
            this.SetParamSimple(map, prefix + "DstDir", this.DstDir);
            this.SetParamSimple(map, prefix + "UploadTime", this.UploadTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SrcDir.", this.SrcDir);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
        }
    }
}

