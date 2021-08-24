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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAgeDetectTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("BizId")]
        public long? BizId{ get; set; }

        /// <summary>
        /// 语音检测子任务列表，列表最多支持100个检测子任务。结构体中包含：
        /// <li>DataId：数据的唯一ID</li>
        /// <li>Url：数据文件的url，为 urlencode 编码，流式则为拉流地址</li>
        /// </summary>
        [JsonProperty("Tasks")]
        public AgeDetectTask[] Tasks{ get; set; }

        /// <summary>
        /// 任务结束时gme后台会自动触发回调
        /// </summary>
        [JsonProperty("Callback")]
        public string Callback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Callback", this.Callback);
        }
    }
}

