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

    public class CreateEditingTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 智能编辑任务参数。
        /// </summary>
        [JsonProperty("EditingInfo")]
        public EditingInfo EditingInfo{ get; set; }

        /// <summary>
        /// 视频源信息。
        /// </summary>
        [JsonProperty("DownInfo")]
        public DownInfo DownInfo{ get; set; }

        /// <summary>
        /// 结果存储信息。对于包含智能拆条、智能集锦或者智能封面的任务必选。
        /// </summary>
        [JsonProperty("SaveInfo")]
        public SaveInfo SaveInfo{ get; set; }

        /// <summary>
        /// 任务结果回调地址信息。
        /// </summary>
        [JsonProperty("CallbackInfo")]
        public CallbackInfo CallbackInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EditingInfo.", this.EditingInfo);
            this.SetParamObj(map, prefix + "DownInfo.", this.DownInfo);
            this.SetParamObj(map, prefix + "SaveInfo.", this.SaveInfo);
            this.SetParamObj(map, prefix + "CallbackInfo.", this.CallbackInfo);
        }
    }
}

