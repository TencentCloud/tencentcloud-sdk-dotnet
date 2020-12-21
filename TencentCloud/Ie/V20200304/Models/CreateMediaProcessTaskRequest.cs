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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMediaProcessTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 编辑处理任务参数。
        /// </summary>
        [JsonProperty("MediaProcessInfo")]
        public MediaProcessInfo MediaProcessInfo{ get; set; }

        /// <summary>
        /// 编辑处理任务输入源列表。
        /// </summary>
        [JsonProperty("SourceInfoSet")]
        public MediaSourceInfo[] SourceInfoSet{ get; set; }

        /// <summary>
        /// 结果存储信息，对于涉及存储的请求必选。部子任务支持数组备份写，具体以对应任务文档为准。
        /// </summary>
        [JsonProperty("SaveInfoSet")]
        public SaveInfo[] SaveInfoSet{ get; set; }

        /// <summary>
        /// 任务结果回调地址信息。部子任务支持数组备份回调，具体以对应任务文档为准。
        /// </summary>
        [JsonProperty("CallbackInfoSet")]
        public CallbackInfo[] CallbackInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MediaProcessInfo.", this.MediaProcessInfo);
            this.SetParamArrayObj(map, prefix + "SourceInfoSet.", this.SourceInfoSet);
            this.SetParamArrayObj(map, prefix + "SaveInfoSet.", this.SaveInfoSet);
            this.SetParamArrayObj(map, prefix + "CallbackInfoSet.", this.CallbackInfoSet);
        }
    }
}

