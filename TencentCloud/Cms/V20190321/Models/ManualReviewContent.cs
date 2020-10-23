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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManualReviewContent : AbstractModel
    {
        
        /// <summary>
        /// 审核批次号
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 审核内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 消息Id
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// 审核内容类型 1 图片 2 视频 3 文本 4 音频
        /// </summary>
        [JsonProperty("ContentType")]
        public long? ContentType{ get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// 机器审核类型，与腾讯机器审核定义一致
        /// 100 正常
        /// 20001 政治
        /// 20002 色情
        /// 20006 违法
        /// 20007 谩骂
        /// 24001 暴恐
        /// 20105 广告
        /// 20103 性感
        /// </summary>
        [JsonProperty("AutoDetailCode")]
        public long? AutoDetailCode{ get; set; }

        /// <summary>
        /// 机器审核结果 0 放过 1 拦截
        /// </summary>
        [JsonProperty("AutoResult")]
        public long? AutoResult{ get; set; }

        /// <summary>
        /// 回调信息标识，回传数据时原样返回
        /// </summary>
        [JsonProperty("CallBackInfo")]
        public string CallBackInfo{ get; set; }

        /// <summary>
        /// 创建时间 格式“2020-01-01 00:00:12”
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 审核优先级，可选值 [1,2,3,4]，其中 1 最高，4 最低
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "AutoDetailCode", this.AutoDetailCode);
            this.SetParamSimple(map, prefix + "AutoResult", this.AutoResult);
            this.SetParamSimple(map, prefix + "CallBackInfo", this.CallBackInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Title", this.Title);
        }
    }
}

