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

namespace TencentCloud.Cloudstudio.V20230508.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifeCycle : AbstractModel
    {
        
        /// <summary>
        /// 工作空间首次初始化时执行
        /// </summary>
        [JsonProperty("Init")]
        public LifeCycleCommand[] Init{ get; set; }

        /// <summary>
        /// 每次工作空间启动时执行
        /// </summary>
        [JsonProperty("Start")]
        public LifeCycleCommand[] Start{ get; set; }

        /// <summary>
        /// 每次工作空间关闭时执行
        /// </summary>
        [JsonProperty("Destroy")]
        public LifeCycleCommand[] Destroy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Init.", this.Init);
            this.SetParamArrayObj(map, prefix + "Start.", this.Start);
            this.SetParamArrayObj(map, prefix + "Destroy.", this.Destroy);
        }
    }
}

