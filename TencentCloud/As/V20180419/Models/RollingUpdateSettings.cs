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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollingUpdateSettings : AbstractModel
    {
        
        /// <summary>
        /// 批次数量。批次数量为大于 0 的正整数，但不能大于待刷新实例数量。
        /// </summary>
        [JsonProperty("BatchNumber")]
        public ulong? BatchNumber{ get; set; }

        /// <summary>
        /// 批次间暂停策略。默认值为 Automatic，取值范围如下：<br><li>FIRST_BATCH_PAUSE：第一批次更新完成后暂停</li><li>BATCH_INTERVAL_PAUSE：批次间暂停</li><li>AUTOMATIC：不暂停
        /// </summary>
        [JsonProperty("BatchPause")]
        public string BatchPause{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchNumber", this.BatchNumber);
            this.SetParamSimple(map, prefix + "BatchPause", this.BatchPause);
        }
    }
}

