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

    public class DescribeScanResultListRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID，登录[控制台](https://console.cloud.tencent.com/gamegme)创建应用得到的AppID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// 查询的任务 ID 列表，任务 ID 列表最多支持 100 个。
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// 任务返回结果数量，默认10，上限500。大文件任务忽略此参数，返回全量结果
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

