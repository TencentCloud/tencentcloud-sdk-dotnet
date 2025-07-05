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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCallStatsGraphRequest : AbstractModel
    {
        
        /// <summary>
        /// uin
        /// </summary>
        [JsonProperty("UinAccount")]
        public string[] UinAccount{ get; set; }

        /// <summary>
        /// 登录用户主账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// 登录用户子账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [JsonProperty("SubBizType")]
        public string SubBizType{ get; set; }

        /// <summary>
        /// 模型标识
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 开始时间戳, 单位为秒
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间戳, 单位为秒
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 应用id列表
        /// </summary>
        [JsonProperty("AppBizIds")]
        public string[] AppBizIds{ get; set; }

        /// <summary>
        /// 筛选子场景(文档解析场景使用)
        /// </summary>
        [JsonProperty("SubScenes")]
        public string[] SubScenes{ get; set; }

        /// <summary>
        /// 应用类型(knowledge_qa应用管理， shared_knowlege 共享知识库)
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "UinAccount.", this.UinAccount);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamSimple(map, prefix + "SubBizType", this.SubBizType);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "AppBizIds.", this.AppBizIds);
            this.SetParamArraySimple(map, prefix + "SubScenes.", this.SubScenes);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
        }
    }
}

