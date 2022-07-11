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

namespace TencentCloud.Irp.V20220324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocItem : AbstractModel
    {
        
        /// <summary>
        /// 内容唯一id
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        [JsonProperty("ItemType")]
        public ulong? ItemType{ get; set; }

        /// <summary>
        /// 内容状态：1 - 上架， 2 - 下架
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 内容生成时间，秒级时间戳（1639624786），需大于0
        /// </summary>
        [JsonProperty("PublishTimestamp")]
        public long? PublishTimestamp{ get; set; }

        /// <summary>
        /// 物料来源ID
        /// </summary>
        [JsonProperty("SourceId")]
        public long? SourceId{ get; set; }

        /// <summary>
        /// 标题名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 内容正文
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// 作者id
        /// </summary>
        [JsonProperty("AuthorId")]
        public string AuthorId{ get; set; }

        /// <summary>
        /// 标签关键词，多个用英文分号分割
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 内容物料描述：物料的描述信息，推荐系统会对内容的描述信息，使用否LP技术，进行分词、提取关键词，作为news的特征使用。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonProperty("PicUrlList")]
        public string[] PicUrlList{ get; set; }

        /// <summary>
        /// 视频url
        /// </summary>
        [JsonProperty("VideoUrlList")]
        public string[] VideoUrlList{ get; set; }

        /// <summary>
        /// 视频时长，时间秒
        /// </summary>
        [JsonProperty("VideoDuration")]
        public long? VideoDuration{ get; set; }

        /// <summary>
        /// 类目层级数，例如3级类目，则填3，和CategoryPath字段的类数据匹配
        /// </summary>
        [JsonProperty("CategoryLevel")]
        public long? CategoryLevel{ get; set; }

        /// <summary>
        /// 类目路径，一级二级三级等依次用英文冒号联接，如体育：“足球:巴塞罗那”
        /// </summary>
        [JsonProperty("CategoryPath")]
        public string CategoryPath{ get; set; }

        /// <summary>
        /// 国家，统一用简写，比如中国则填写CN
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// 内容过期时间，秒级时间戳（1639624786），如未填，则默认PublishTimestamp往后延一年
        /// </summary>
        [JsonProperty("ExpireTimestamp")]
        public long? ExpireTimestamp{ get; set; }

        /// <summary>
        /// 所属话题
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 作者粉丝数
        /// </summary>
        [JsonProperty("AuthorFans")]
        public long? AuthorFans{ get; set; }

        /// <summary>
        /// 作者评级
        /// </summary>
        [JsonProperty("AuthorLevel")]
        public string AuthorLevel{ get; set; }

        /// <summary>
        /// 内容累计收藏次数
        /// </summary>
        [JsonProperty("CollectCnt")]
        public long? CollectCnt{ get; set; }

        /// <summary>
        /// 内容累积点赞次数
        /// </summary>
        [JsonProperty("PraiseCnt")]
        public long? PraiseCnt{ get; set; }

        /// <summary>
        /// 内容累计评论次数
        /// </summary>
        [JsonProperty("CommentCnt")]
        public long? CommentCnt{ get; set; }

        /// <summary>
        /// 内容累计分享次数
        /// </summary>
        [JsonProperty("ShareCnt")]
        public long? ShareCnt{ get; set; }

        /// <summary>
        /// 内容累积打赏数
        /// </summary>
        [JsonProperty("RewardCnt")]
        public long? RewardCnt{ get; set; }

        /// <summary>
        /// 内容质量评分，类似豆瓣电影的评分，这里为100分制，比如97分，满分100分，最低0分，范围外的将会被拦截
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// 内容池id，用于分内容池召回，一个内容支持指定一个或多个内容池， 内容池id不建议使用0（0表示不区分内容池）
        /// </summary>
        [JsonProperty("PoolIdList")]
        public string[] PoolIdList{ get; set; }

        /// <summary>
        /// 描述用户标签
        /// </summary>
        [JsonProperty("TagInfoList")]
        public TagInfo[] TagInfoList{ get; set; }

        /// <summary>
        /// json字符串，用于物料数据的扩展
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ItemType", this.ItemType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PublishTimestamp", this.PublishTimestamp);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "AuthorId", this.AuthorId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamArraySimple(map, prefix + "PicUrlList.", this.PicUrlList);
            this.SetParamArraySimple(map, prefix + "VideoUrlList.", this.VideoUrlList);
            this.SetParamSimple(map, prefix + "VideoDuration", this.VideoDuration);
            this.SetParamSimple(map, prefix + "CategoryLevel", this.CategoryLevel);
            this.SetParamSimple(map, prefix + "CategoryPath", this.CategoryPath);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "ExpireTimestamp", this.ExpireTimestamp);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "AuthorFans", this.AuthorFans);
            this.SetParamSimple(map, prefix + "AuthorLevel", this.AuthorLevel);
            this.SetParamSimple(map, prefix + "CollectCnt", this.CollectCnt);
            this.SetParamSimple(map, prefix + "PraiseCnt", this.PraiseCnt);
            this.SetParamSimple(map, prefix + "CommentCnt", this.CommentCnt);
            this.SetParamSimple(map, prefix + "ShareCnt", this.ShareCnt);
            this.SetParamSimple(map, prefix + "RewardCnt", this.RewardCnt);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "PoolIdList.", this.PoolIdList);
            this.SetParamArrayObj(map, prefix + "TagInfoList.", this.TagInfoList);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
        }
    }
}

